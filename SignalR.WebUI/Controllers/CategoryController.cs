﻿using Microsoft.AspNetCore.Mvc;

namespace SignalR.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
