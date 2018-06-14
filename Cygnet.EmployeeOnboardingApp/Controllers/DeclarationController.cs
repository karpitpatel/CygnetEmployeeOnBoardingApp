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
    public class DeclarationController : Controller
    {

        private readonly IDeclarationManager _declarationManager;
        
        public DeclarationController(IDeclarationManager declarationManager)
        {
            _declarationManager = declarationManager;
        }

    

       
        public ActionResult Create()
        {
            var declaration = _declarationManager.GetDeclaration((int)Session["UserId"]);
            if (declaration == null)
                return View(new DeclarationViewModel() { UserId = (int)Session["UserId"] });
            else
                return View(declaration);
            
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
     
        public ActionResult Create(DeclarationViewModel declarationViewModel)
        {
            if (ModelState.IsValid)
            {
                _declarationManager.IsRegister(declarationViewModel);
                return RedirectToAction("Create", "NomineeDetails");
               
            }

            return View(declarationViewModel);
        }

       
        


    }
}
