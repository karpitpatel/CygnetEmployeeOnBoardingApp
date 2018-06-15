using Cygnet.EmployeeOnboardingApp.Domain.Manager;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using System.Web.Mvc;

namespace Cygnet.EmployeeOnboardingApp.Controllers
{
    public class OriginDetailsController : Controller
    {
        private readonly IOriginDetailsManager _originDetailsManager;

        public OriginDetailsController(IOriginDetailsManager originDetailsManager)
        {
            _originDetailsManager = originDetailsManager;
        }

        public ActionResult Create()
        {
            var originDetails = _originDetailsManager.GetOriginDetails((int)Session["UserId"]);
            if (originDetails == null)
                return View(new OriginDetailsViewModel() { UserId = (int)Session["UserId"] });
            else
                return View(originDetails);

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OriginDetailsViewModel originDetailsViewModel)
        {
            if (ModelState.IsValid)
            {
                _originDetailsManager.IsRegister(originDetailsViewModel);
                return RedirectToAction("Create", "WorkingHistoryDetails");

            }

            return View(originDetailsViewModel);
        }
    }
}