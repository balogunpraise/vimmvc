﻿using Microsoft.AspNetCore.Mvc;

namespace vimmvc.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
