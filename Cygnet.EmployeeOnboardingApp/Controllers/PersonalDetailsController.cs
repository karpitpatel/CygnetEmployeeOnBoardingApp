using Cygnet.EmployeeOnboardingApp.Domain.Manager;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using System.Web.Mvc;

namespace Cygnet.EmployeeOnboardingApp.Controllers
{
    public class PersonalDetailsController : Controller
    {
        private readonly IPersonalDetailsManager _personalDetailsManager;

        public PersonalDetailsController(IPersonalDetailsManager personalDetailsManager)
        {
            _personalDetailsManager = personalDetailsManager;
        }

        public ActionResult Create()
        {
            var personal = _personalDetailsManager.GetPersonalDetails((int)Session["UserId"]);
            if (personal == null)
                return View(new PersonalDetailsViewModel() { UserId = (int)Session["UserId"]});
            else
                return View(personal);
           
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
             public ActionResult Create(PersonalDetailsViewModel personalDetailsViewModel)
        {
            if (ModelState.IsValid)
            {
                _personalDetailsManager.IsRegister(personalDetailsViewModel);
              return RedirectToAction("Create", "ContactDetails");
           
            }

            return View(personalDetailsViewModel);
        }
    }
}