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

        // GET: DeclarationDetails
        //public ActionResult Index(int id)


       
        public ActionResult Create()
        {
            var declaration = _declarationManager.GetDeclaration((int)Session["EmpId"]);
            if (declaration == null)
                return View(new DeclarationViewModel() { UserId = (int)Session["EmpId"] });
            else
                return View(declaration);
            //return View();
        }

        // POST: DeclarationDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //  public ActionResult Create([Bind(Include = "Kyc_Details,Is_Mem_Epf_Schema,Dt_Allot_Ins_No,Dt_Issue_Tic")] DeclarationViewModel declarationViewModel)
        public ActionResult Create(DeclarationViewModel declarationViewModel)
        {
            if (ModelState.IsValid)
            {
                _declarationManager.IsRegister(declarationViewModel);
                return RedirectToAction("Create", "NomineeDetails");
                // return View();
            }

            return View(declarationViewModel);
        }

        // GET: DeclarationDetails/Edit/5
        


    }
}
