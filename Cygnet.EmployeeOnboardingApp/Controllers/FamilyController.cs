//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using Cygnet.EmployeeOnboardingApp.Data.Context;
//using Cygnet.EmployeeOnboardingApp.Data.Model;

//namespace Cygnet.EmployeeOnboardingApp.Controllers
//{
//    public class FamilyController : Controller
//    {
//        private EmployeeOnBoardingEntities db = new EmployeeOnBoardingEntities();

//        // GET: Family
//        public ActionResult Index()
//        {
//            var families = db.Families.Include(f => f.User);
//            return View(families.ToList());
//        }

//        // GET: Family/Details/5
//        public ActionResult Details(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Family family = db.Families.Find(id);
//            if (family == null)
//            {
//                return HttpNotFound();
//            }
//            return View(family);
//        }

//        // GET: Family/Create
//        public ActionResult Create()
//        {
//            ViewBag.UserId = new SelectList(db.Users, "Id", "Name");
//            return View();
//        }

//        // POST: Family/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create([Bind(Include = "Id,Name,Relation,Contact,Occupation,Dob,Aadhar_No,Residing_tog,UserId,Created,Modified,RowVersion")] Family family)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Families.Add(family);
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }

//            ViewBag.UserId = new SelectList(db.Users, "Id", "Name", family.UserId);
//            return View(family);
//        }

//        // GET: Family/Edit/5
//        public ActionResult Edit(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Family family = db.Families.Find(id);
//            if (family == null)
//            {
//                return HttpNotFound();
//            }
//            ViewBag.UserId = new SelectList(db.Users, "Id", "Name", family.UserId);
//            return View(family);
//        }

//        // POST: Family/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit([Bind(Include = "Id,Name,Relation,Contact,Occupation,Dob,Aadhar_No,Residing_tog,UserId,Created,Modified,RowVersion")] Family family)
//        {
//            if (ModelState.IsValid)
//            {
//                db.Entry(family).State = EntityState.Modified;
//                db.SaveChanges();
//                return RedirectToAction("Index");
//            }
//            ViewBag.UserId = new SelectList(db.Users, "Id", "Name", family.UserId);
//            return View(family);
//        }

//        // GET: Family/Delete/5
//        public ActionResult Delete(int? id)
//        {
//            if (id == null)
//            {
//                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//            }
//            Family family = db.Families.Find(id);
//            if (family == null)
//            {
//                return HttpNotFound();
//            }
//            return View(family);
//        }

//        // POST: Family/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public ActionResult DeleteConfirmed(int id)
//        {
//            Family family = db.Families.Find(id);
//            db.Families.Remove(family);
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }
//    }
//}


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
    public class FamilyController : Controller
    {

        private readonly IFamilyManager _familyManager;

        public FamilyController(IFamilyManager familyManager)
        {
            _familyManager = familyManager;
        }
        public ActionResult Index()
        {
             var family = _familyManager.GetAllFamily((int)Session["EmpId"]);
           // var family = _familyManager.GetFamily((int)Session["EmpId"]);
            if (family == null)
                return View(new List<FamilyViewModel>());
            else
                //return View(family);
             return View(family.ToList());
            //return View();
        }



        public ActionResult Create()
        {
            var family = _familyManager.GetFamily((int)Session["EmpId"]);
            //if (family == null)
              return View(new FamilyViewModel() { UserId = (int)Session["EmpId"] });
            //else
            //    return View(family);
            //return View();

        }

        // POST: FamilyDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        // public ActionResult Create([Bind(Include = "Acc_No,Ifsc_Code,Pan_No,Uan_No,Ins_No,Mediclaim,Life_Ins,Fam_PensionScheme,Pf_No")] FamilyDetailsViewModel familyDetailsViewModel)
        public ActionResult Create(FamilyViewModel familyViewModel)
        {
            if (ModelState.IsValid)
            {
                _familyManager.IsRegister(familyViewModel);
                // return RedirectToAction("ThankYouPage", "Account");
                return View();
            }

            return View(familyViewModel);
        }
        public ActionResult Edit(int id)
        {
           // Session["RelId"] = id;
            var family = _familyManager.GetFamily(id);
            if (family == null)
                return View("Index");
            else
            {

                return View(family);
            }



        }
    }
}
