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
    public class FamilyController : Controller
    {

        private readonly IFamilyManager _familyManager;

        public FamilyController(IFamilyManager familyManager)
        {
            _familyManager = familyManager;
        }
        public ActionResult Index()
        {
             var family = _familyManager.GetAllFamily((int)Session["UserId"]);
          
            if (family == null)
                return View(new List<FamilyViewModel>());
            else
                
             return View(family.ToList());
          
        }



        public ActionResult Create()
        {
            var family = _familyManager.GetFamily((int)Session["UserId"]);
            //if (family == null)
              return View(new FamilyViewModel() { UserId = (int)Session["UserId"] });
            //else
            //    return View(family);
            //return View();

        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
         public ActionResult Create(FamilyViewModel familyViewModel)
        {
            if (ModelState.IsValid)
            {
                _familyManager.IsRegister(familyViewModel);
                // return RedirectToAction("ThankYouPage", "Account");
                return View();
            }

            return View(familyViewModel);
        }
        public ActionResult Edit(int Id)
        {
           
            var family = _familyManager.GetFamily(Id);
            if (family == null)
                return View("Index");
            else
            {

                return View(family);
            }



        }
    }
}
