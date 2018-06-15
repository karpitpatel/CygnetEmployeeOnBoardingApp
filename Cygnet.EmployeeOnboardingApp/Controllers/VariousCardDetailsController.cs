using Cygnet.EmployeeOnboardingApp.Domain.Manager;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using System.Web.Mvc;

namespace Cygnet.EmployeeOnboardingApp.Controllers
{
    public class VariousCardDetailsController : Controller
    {
        private readonly IVariousCardDetailsManager _variousCardDetailsManager;

        public VariousCardDetailsController(IVariousCardDetailsManager variousCardDetailsManager)
        {
            _variousCardDetailsManager = variousCardDetailsManager;
        }

        public ActionResult Create()
        {
            var variousCard = _variousCardDetailsManager.GetVariousCardDetails((int)Session["UserId"]);
            if (variousCard == null)
                return View(new VariousCardDetailsViewModel() { UserId = (int)Session["UserId"] });
            else
                return View(variousCard);

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VariousCardDetailsViewModel variousCardDetailsViewModel)
        {
            if (ModelState.IsValid)
            {
                _variousCardDetailsManager.IsRegister(variousCardDetailsViewModel);
                return RedirectToAction("Index", "Family");

            }

            return View(variousCardDetailsViewModel);
        }
    }
}