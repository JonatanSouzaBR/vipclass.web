﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VIPCLASS.Controllers
{
    public class CourseController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Start()
        {
            return View();
        }

        public IActionResult Single()
        {
            return View();
        }

        public IActionResult Multiple()
        {
            return View();
        }
    }
}