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
    public class ContactDetailsController : Controller
    {

        private readonly IContactDetailsManager _contactDetailsManager;
        public ContactDetailsController(IContactDetailsManager contactDetailsManager)
        {
            _contactDetailsManager = contactDetailsManager;
        }

      
        public ActionResult Create()
        {
            var contact = _contactDetailsManager.GetContactDetails((int)Session["UserId"]);
            if (contact == null)
                return View(new ContactDetailsViewModel() { UserId = (int)Session["UserId"] });
            else
                return View(contact);
           
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
         public ActionResult Create(ContactDetailsViewModel contactDetailsViewModel)
        {
            if (ModelState.IsValid)
            {
                _contactDetailsManager.IsRegister(contactDetailsViewModel);
                return RedirectToAction("Create", "BankDetails");
         
            }

            return View(contactDetailsViewModel);
        }

        
       


    }
}
