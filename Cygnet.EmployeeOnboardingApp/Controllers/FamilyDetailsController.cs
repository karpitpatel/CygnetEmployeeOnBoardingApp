﻿using Cygnet.EmployeeOnboardingApp.Domain.Manager;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using System.Web.Mvc;

namespace Cygnet.EmployeeOnboardingApp.Controllers
{
    public class FamilyDetailsController : Controller
    {
        private readonly IFamilyDetailsManager _familyDetailsManager;

        public FamilyDetailsController(IFamilyDetailsManager familyDetailsManager)
        {
            _familyDetailsManager = familyDetailsManager;
        }

        public ActionResult Create()
        {
            var family = _familyDetailsManager.GetFamilyDetails((int)Session["EmpId"]);
            if (family == null)
                return View(new FamilyDetailsViewModel() { UserId = (int)Session["EmpId"] });
            else
                return View(family);
            //return View();
        }

        // POST: FamilyDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        // public ActionResult Create([Bind(Include = "Acc_No,Ifsc_Code,Pan_No,Uan_No,Ins_No,Mediclaim,Life_Ins,Fam_PensionScheme,Pf_No")] FamilyDetailsViewModel familyDetailsViewModel)
        public ActionResult Create(FamilyDetailsViewModel familyDetailsViewModel)
        {
            if (ModelState.IsValid)
            {
                _familyDetailsManager.IsRegister(familyDetailsViewModel);
                // return RedirectToAction("ThankYouPage", "Account");
                return View();
            }

            return View(familyDetailsViewModel);
        }
    }
}