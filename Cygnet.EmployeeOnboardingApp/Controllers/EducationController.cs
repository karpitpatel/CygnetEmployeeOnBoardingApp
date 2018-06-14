using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Cygnet.EmployeeOnboardingApp.Data.Context;
using Cygnet.EmployeeOnboardingApp.Data.Model;
using Cygnet.EmployeeOnboardingApp.Core.Data.Model;
using Cygnet.EmployeeOnboardingApp.Core.Data.Context;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using Cygnet.EmployeeOnboardingApp.Core.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Domain.Manager;

namespace Cygnet.EmployeeOnboardingApp.Controllers
{
    public class EducationController : Controller
    {

        private readonly IEducationManager _educationManager;

        public EducationController(IEducationManager educationManager)
        {
            _educationManager = educationManager;
        }
        public ActionResult Index()
        {
            var education = _educationManager.GetAllEducation((int)Session["UserId"]);
          
            if (education == null)
                return View(new List<EducationViewModel>());
            else
               
                return View(education.ToList());
        }



        public ActionResult Create()
        {
            var education = _educationManager.GetEducation((int)Session["UserId"]);
          
            return View(new EducationViewModel() { UserId = (int)Session["UserId"] });
       

        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EducationViewModel educationViewModel)
        {
            if (ModelState.IsValid)
            {
                _educationManager.IsRegister(educationViewModel);
              
                return View();
            }

            return View(educationViewModel);
        }
        public ActionResult Edit(int id)
        {

            var education = _educationManager.GetEducation(id);
            if (education == null)
                return View("Index");
            else
            {

                return View(education);
            }



        }
    }
}
