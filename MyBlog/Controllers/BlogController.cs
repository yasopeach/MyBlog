﻿using Microsoft.AspNetCore.Mvc;

namespace MyBlog.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
