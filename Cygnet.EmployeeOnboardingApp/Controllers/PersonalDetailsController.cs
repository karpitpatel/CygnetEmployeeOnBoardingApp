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
    public class PersonalDetailsController : Controller
    {

        private readonly IPersonalDetailsManager _personalDetailsManager;
       
        public PersonalDetailsController(IPersonalDetailsManager personalDetailsManager)
        {
            _personalDetailsManager = personalDetailsManager;
        }

        
      
       
        public ActionResult Create()
        {
            var personal = _personalDetailsManager.GetPersonalDetails((int)Session["UserId"]);
            if (personal == null)
                return View(new PersonalDetailsViewModel() { UserId = (int)Session["UserId"]});
            else
                return View(personal);
           
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
             public ActionResult Create(PersonalDetailsViewModel personalDetailsViewModel)
        {
            if (ModelState.IsValid)
            {
                _personalDetailsManager.IsRegister(personalDetailsViewModel);
              return RedirectToAction("Create", "ContactDetails");
           
            }

            return View(personalDetailsViewModel);
        }

        


    }
}
