using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreIdentityTest.Models;
using Microsoft.AspNetCore.Authorization;

namespace CoreIdentityTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Details()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Details(int id)
        //{
        //    return View();
        //}

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Create(int id)
        //{
        //    return View();
        //}

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Edit(int id)
        //{
        //    return View();
        //}
    }
}
