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
    public class OriginDetailsController : Controller
    {

        private readonly IOriginDetailsManager _originDetailsManager;
        
        public OriginDetailsController(IOriginDetailsManager originDetailsManager)
        {
            _originDetailsManager = originDetailsManager;
        }

         public ActionResult Create()
        {
            var originDetails = _originDetailsManager.GetOriginDetails((int)Session["UserId"]);
            if (originDetails == null)
                return View(new OriginDetailsViewModel() { UserId = (int)Session["UserId"] });
            else
                return View(originDetails);
          
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
         public ActionResult Create(OriginDetailsViewModel originDetailsViewModel)
        {
            if (ModelState.IsValid)
            {
                _originDetailsManager.IsRegister(originDetailsViewModel);
                return RedirectToAction("Create", "WorkingHistoryDetails");
               
            }

            return View(originDetailsViewModel);
        }

        


    }
}
