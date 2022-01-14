using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace VIPCLASS.ViewModels
{
    public class SingleCourseViewModel
    {
        public IFormFile File { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
