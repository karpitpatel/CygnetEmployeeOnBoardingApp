﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cygnet.EmployeeOnboardingApp.Domain.Manager;

namespace Cygnet.EmployeeOnboardingApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITestUOWManager _testUOWManager;
        public HomeController(ITestUOWManager testUOWManager)
        {
            _testUOWManager = testUOWManager;
        }

        public ActionResult Index()
        {
            return RedirectToAction("Login", "Account");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}