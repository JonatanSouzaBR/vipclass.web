using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using VIPCLASS.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VIPCLASS.Controllers
{
    public class CourseController : Controller
    {
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

            return RedirectToAction("Index", "Home");
        }
    }
}
