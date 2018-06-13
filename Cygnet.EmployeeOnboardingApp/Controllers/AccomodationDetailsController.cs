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
    /// <summary>
    /// 
    /// </summary>
    public class AccomodationDetailsController : Controller
    {

        private readonly IAccomodationDetailsManager _accomodationDetailsManager;
        /*  public AccomodationDetailsController()
          {

          }*/
        public AccomodationDetailsController(IAccomodationDetailsManager accomodationDetailsManager)
        {
            _accomodationDetailsManager = accomodationDetailsManager;
        }

        // GET: AccomodationDetails
        //public ActionResult Index(int id)


        // GET: AccomodationDetails/Details/5
        public ActionResult Details(int id)
        {


            return View();
        }

        // GET: AccomodationDetails/Create
        public ActionResult Create()
        {
            var accomodation = _accomodationDetailsManager.GetAccomodationDetails((int)Session["EmpId"]);
            if (accomodation == null)
                return View(new AccomodationDetailsViewModel() { UserId = (int)Session["EmpId"] });
            else
                return View(accomodation);
            //return View();
        }

        // POST: AccomodationDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Rent_Ownership,Owner_Name,Owner_Contact,Owner_Occupation,Owner_Addr,Neigh1_Name,Neigh1_Contact,Neigh1_Occupation,Neigh2_Name,Neigh2_Contact,Neigh2_Occupation")] AccomodationDetailsViewModel accomodationDetailsViewModel)
        public ActionResult Create(AccomodationDetailsViewModel accomodationDetailsViewModel)
        {
            if (ModelState.IsValid)
            {
                _accomodationDetailsManager.IsRegister(accomodationDetailsViewModel);
                return RedirectToAction("Create", "AdditionalDetails");
                // return View();
            }

            return View(accomodationDetailsViewModel);
        }

        


    }
}
