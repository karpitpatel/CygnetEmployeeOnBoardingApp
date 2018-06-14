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
    public class VariousCardDetailsController : Controller
    {

        private readonly IVariousCardDetailsManager _variousCardDetailsManager;
       
        public VariousCardDetailsController(IVariousCardDetailsManager variousCardDetailsManager)
        {
            _variousCardDetailsManager = variousCardDetailsManager;
        }

     
        public ActionResult Create()
        {
            var variousCard = _variousCardDetailsManager.GetVariousCardDetails((int)Session["UserId"]);
            if (variousCard == null)
                return View(new VariousCardDetailsViewModel() { UserId = (int)Session["UserId"] });
            else
                return View(variousCard);
         
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
          public ActionResult Create(VariousCardDetailsViewModel variousCardDetailsViewModel)
        {
            if (ModelState.IsValid)
            {
                _variousCardDetailsManager.IsRegister(variousCardDetailsViewModel);
                return RedirectToAction("Index", "Family");
               
            }

            return View(variousCardDetailsViewModel);
        }

      
       

    }
}
