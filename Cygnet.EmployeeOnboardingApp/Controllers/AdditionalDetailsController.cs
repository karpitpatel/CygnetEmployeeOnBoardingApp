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
    public class AdditionalDetailsController : Controller
    {

        private readonly IAdditionalDetailsManager _additionalDetailsManager;
        
        public AdditionalDetailsController(IAdditionalDetailsManager additionalDetailsManager)
        {
            _additionalDetailsManager = additionalDetailsManager;
        }

  


          public ActionResult Create()
        {
            var additional = _additionalDetailsManager.GetAdditionalDetails((int)Session["UserId"]);
            if (additional == null)
                return View(new AdditionalDetailsViewModel() { UserId = (int)Session["UserId"] });
            else
                return View(additional);
           
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
       
        public ActionResult Create( AdditionalDetailsViewModel additionalDetailsViewModel)
        {
            if (ModelState.IsValid)
            {
                _additionalDetailsManager.IsRegister(additionalDetailsViewModel);
                return RedirectToAction("Create", "Declaration");
              
            }

            return View(additionalDetailsViewModel);
        }

    

    }
}
