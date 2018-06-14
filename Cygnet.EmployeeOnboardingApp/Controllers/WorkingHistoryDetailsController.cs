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
    public class WorkingHistoryDetailsController : Controller
    {

        private readonly IWorkingHistoryDetailsManager _workingHistoryDetailsManager;
      
        public WorkingHistoryDetailsController(IWorkingHistoryDetailsManager workingHistoryDetailsManager)
        {
            _workingHistoryDetailsManager = workingHistoryDetailsManager;
        }

        
        
        public ActionResult Create()
        {
            var workingHistoryDetails = _workingHistoryDetailsManager.GetWorkingHistoryDetails((int)Session["UserId"]);
            if (workingHistoryDetails == null)
                return View(new WorkingHistoryDetailsViewModel() { UserId = (int)Session["UserId"] });
            else
                return View(workingHistoryDetails);
    
        }

     
        [HttpPost]
        [ValidateAntiForgeryToken]
      
        public ActionResult Create(WorkingHistoryDetailsViewModel workingHistoryDetailsViewModel)
        {
            if (ModelState.IsValid)
            {
                _workingHistoryDetailsManager.IsRegister(workingHistoryDetailsViewModel);
                return RedirectToAction("Create", "VariousCardDetails");
               
            }

            return View(workingHistoryDetailsViewModel);
        }

     
        


    }
}
