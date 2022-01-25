using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VIPCLASS.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VIPCLASS.Controllers
{
    public class CourseController : Controller
    {
        HttpClientHandler _clienteHandler = new HttpClientHandler();
        AddCourseSignature _course = new AddCourseSignature();

        [Obsolete]
        private IHostingEnvironment _env;

        [Obsolete]
        public CourseController(IHostingEnvironment env)
        {
            _env = env;
        }

        public IActionResult Start() => View();

        public IActionResult Single() => View();

        public IActionResult Multiple() => View();

        [RequestFormLimits(ValueLengthLimit = int.MaxValue, MultipartBodyLengthLimit = int.MaxValue)]
        [DisableRequestSizeLimit]
        [Consumes("multipart/form-data")]
        [HttpPost]
        [Obsolete]
        public async Task<IActionResult> CreateSingleCourse(SingleCourseViewModel model)
        {
            var dir = _env.ContentRootPath;

            using var filestream = new FileStream(Path.Combine(dir, model.File.FileName), FileMode.Create, FileAccess.Write);

            await model.File.CopyToAsync(filestream);


            #region [ Connect to api ]

            _course = new AddCourseSignature
            {
                Active = true,
                Description = model.Description,
                IdCategorie = 1,
                ImageCover = new byte(),
                Price = model.Price,
                Title = model.Name,
                Producer = new AddProducerSignature { Active = true, Royalts = "2", Wallet = "djshfjhsdjfhsdjf"},
                //CoProducer = new List<AddCoProducerSignature>().Add(new AddCoProducerSignature { Active = true,})
            };

            using (var httpCliente = new HttpClient(_clienteHandler))
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(_course), Encoding.UTF8, "application/json");

                using (var response = await httpCliente.PostAsync("https://localhost:5002/v1/course/Add", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    _course = JsonConvert.DeserializeObject<AddCourseSignature>(apiResponse);
                }
            }

            #endregion


            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task Add(AddCourseSignature model)
        {
            _course = new AddCourseSignature();

            using (var httpCliente = new HttpClient(_clienteHandler))
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

                using (var response = await httpCliente.PostAsync("https://localhost:5002/v1/course/Add", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    _course = JsonConvert.DeserializeObject<AddCourseSignature>(apiResponse);
                }
            }
        }
    }
}
