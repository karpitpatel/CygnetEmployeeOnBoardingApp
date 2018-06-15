using Cygnet.EmployeeOnboardingApp.Domain.Manager;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using System.Web.Mvc;

namespace Cygnet.EmployeeOnboardingApp.Controllers
{
    public class AccomodationDetailsController : Controller
    {
        private readonly IAccomodationDetailsManager _accomodationDetailsManager;


        public AccomodationDetailsController(IAccomodationDetailsManager accomodationDetailsManager)
        {
            _accomodationDetailsManager = accomodationDetailsManager;
        }


        public ActionResult Details(int id)
        {
            return View();
        }


        public ActionResult Create()
        {
            var accomodation = _accomodationDetailsManager.GetAccomodationDetails((int)Session["UserId"]);
            if (accomodation == null)
                return View(new AccomodationDetailsViewModel() { UserId = (int)Session["UserId"] });
            else
                return View(accomodation);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(AccomodationDetailsViewModel accomodationDetailsViewModel)
        {
            if (ModelState.IsValid)
            {
                _accomodationDetailsManager.IsRegister(accomodationDetailsViewModel);
                return RedirectToAction("Create", "AdditionalDetails");

            }

            return View(accomodationDetailsViewModel);
        }
    }
}