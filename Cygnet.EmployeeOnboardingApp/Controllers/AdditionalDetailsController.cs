using Cygnet.EmployeeOnboardingApp.Domain.Manager;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using System.Web.Mvc;

namespace Cygnet.EmployeeOnboardingApp.Controllers
{
    public class AdditionalDetailsController : Controller
    {
        private readonly IAdditionalDetailsManager _additionalDetailsManager;

        public AdditionalDetailsController(IAdditionalDetailsManager additionalDetailsManager)
        {
            _additionalDetailsManager = additionalDetailsManager;
        }

        public ActionResult Create()
        {
            var additional = _additionalDetailsManager.GetAdditionalDetails((int)Session["EmpId"]);
            if (additional == null)
                return View(new AdditionalDetailsViewModel() { UserId = (int)Session["EmpId"] });
            else
                return View(additional);
            //return View();
        }

        // POST: AdditionalDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Rel_With_Present_Emp,Name_Emp,Relationship,Details_If_Worked_Before")] AdditionalDetailsViewModel additionalDetailsViewModel)
        public ActionResult Create(AdditionalDetailsViewModel additionalDetailsViewModel)
        {
            if (ModelState.IsValid)
            {
                _additionalDetailsManager.IsRegister(additionalDetailsViewModel);
                return RedirectToAction("Create", "Declaration");
                //return View();
            }

            return View(additionalDetailsViewModel);
        }
    }
}