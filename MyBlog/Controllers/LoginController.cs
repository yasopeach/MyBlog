﻿using Microsoft.AspNetCore.Mvc;

namespace MyBlog.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
