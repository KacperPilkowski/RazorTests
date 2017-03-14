﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RazorTests.Models;

namespace RazorTests.Controllers
{
    public class HomeController : Controller
    {
        private Product myProduct = new Product
        {
            ProductID = 1,
            Name = "Kajak",
            Description = "jednoosobowa łódka",
            Category = "Sporty wodne",
            Price = 275M
        };

        // GET: Home
        public ActionResult Index()
        {
            return View(myProduct);
        }
    }
}