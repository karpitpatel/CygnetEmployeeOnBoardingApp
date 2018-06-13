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
            var personal = _personalDetailsManager.GetPersonalDetails((int)Session["EmpId"]);
            if (personal == null)
                return View(new PersonalDetailsViewModel() { UserId = (int)Session["EmpId"]});
            else
                return View(personal);
            //return View();
        }

        // POST: PersonalDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Name,Father_Name,Sex,Marital_Stat,Date_Anniv,Dob,Name_Company,Designation,Department,Blood_Grp,Allergy,Ailment")] PersonalDetailsViewModel personalDetailsViewModel)
        public ActionResult Create(PersonalDetailsViewModel personalDetailsViewModel)
        {
            if (ModelState.IsValid)
            {
                _personalDetailsManager.IsRegister(personalDetailsViewModel);
              return RedirectToAction("Create", "ContactDetails");
              //return View();
            }

            return View(personalDetailsViewModel);
        }

        


    }
}
