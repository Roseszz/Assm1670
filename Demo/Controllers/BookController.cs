﻿using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
