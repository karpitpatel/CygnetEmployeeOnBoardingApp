using Cygnet.EmployeeOnboardingApp.Domain.Manager;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using System.Web.Mvc;

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

        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(NomineeDetailsViewModel nomineeDetailsViewModel)
        {
            if (ModelState.IsValid)
            {
                _nomineeDetailsManager.IsRegister(nomineeDetailsViewModel);
                return RedirectToAction("Create", "OriginDetails");

            }

            return View(nomineeDetailsViewModel);
        }
    }
}