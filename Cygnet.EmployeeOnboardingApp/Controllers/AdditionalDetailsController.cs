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
            var additional = _additionalDetailsManager.GetAdditionalDetails((int)Session["UserId"]);
            if (additional == null)
                return View(new AdditionalDetailsViewModel() { UserId = (int)Session["UserId"] });
            else
                return View(additional);

        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(AdditionalDetailsViewModel additionalDetailsViewModel)
        {
            if (ModelState.IsValid)
            {
                _additionalDetailsManager.IsRegister(additionalDetailsViewModel);
                return RedirectToAction("Create", "Declaration");

            }

            return View(additionalDetailsViewModel);
        }
    }
}