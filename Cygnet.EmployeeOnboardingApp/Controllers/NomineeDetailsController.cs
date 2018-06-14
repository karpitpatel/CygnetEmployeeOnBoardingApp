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
    public class NomineeDetailsController : Controller
    {

        private readonly INomineeDetailsManager _nomineeDetailsManager;
        
        public NomineeDetailsController(INomineeDetailsManager nomineeDetailsManager)
        {
            _nomineeDetailsManager = nomineeDetailsManager;
        }

        
       
        public ActionResult Create()
        {
            var nomineeDetails = _nomineeDetailsManager.GetNomineeDetails((int)Session["UserId"]);
            if (nomineeDetails == null)
                return View(new NomineeDetailsViewModel() { UserId = (int)Session["UserId"] });
            else
                return View(nomineeDetails);
            //return View();
        }

        // POST: NomineeDetailsDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        // public ActionResult Create([Bind(Include = "Name,Relationship,Address")] NomineeDetailsViewModel nomineeDetailsViewModel)
        public ActionResult Create(NomineeDetailsViewModel nomineeDetailsViewModel)
        {
            if (ModelState.IsValid)
            {
                _nomineeDetailsManager.IsRegister(nomineeDetailsViewModel);
                return RedirectToAction("Create", "OriginDetails");
              //  return View();
            }

            return View(nomineeDetailsViewModel);
        }

        

    }
}
