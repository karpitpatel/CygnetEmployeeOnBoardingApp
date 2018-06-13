using Cygnet.EmployeeOnboardingApp.Domain.Manager;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Cygnet.EmployeeOnboardingApp.Controllers
{
    public class EducationController : Controller
    {
        private readonly IEducationManager _educationManager;

        public EducationController(IEducationManager educationManager)
        {
            _educationManager = educationManager;
        }

        public ActionResult Index()
        {
            var education = _educationManager.GetAllEducation((int)Session["EmpId"]);
            // var education = _educationManager.GetEducation((int)Session["EmpId"]);
            if (education == null)
                return View(new List<EducationViewModel>());
            else
                //return View(education);
                return View(education.ToList());
            //return View();
        }

        public ActionResult Create()
        {
            var education = _educationManager.GetEducation((int)Session["EmpId"]);
            //if (education == null)
            return View(new EducationViewModel() { UserId = (int)Session["EmpId"] });
            //else
            //    return View(education);
            //return View();
        }

        // POST: EducationDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        // public ActionResult Create([Bind(Include = "Acc_No,Ifsc_Code,Pan_No,Uan_No,Ins_No,Mediclaim,Life_Ins,Fam_PensionScheme,Pf_No")] EducationDetailsViewModel educationDetailsViewModel)
        public ActionResult Create(EducationViewModel educationViewModel)
        {
            if (ModelState.IsValid)
            {
                _educationManager.IsRegister(educationViewModel);
                // return RedirectToAction("ThankYouPage", "Account");
                return View();
            }

            return View(educationViewModel);
        }

        public ActionResult Edit(int id)
        {
            // Session["RelId"] = id;
            var education = _educationManager.GetEducation(id);
            if (education == null)
                return View("Index");
            else
            {
                return View(education);
            }
        }
    }
}