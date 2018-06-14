using Cygnet.EmployeeOnboardingApp.Domain.Manager;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using System.Web.Mvc;

namespace Cygnet.EmployeeOnboardingApp.Controllers
{
    public class ContactDetailsController : Controller
    {
        private readonly IContactDetailsManager _contactDetailsManager;

        public ContactDetailsController(IContactDetailsManager contactDetailsManager)
        {
            _contactDetailsManager = contactDetailsManager;
        }

        public ActionResult Create()
        {
            var contact = _contactDetailsManager.GetContactDetails((int)Session["UserId"]);
            if (contact == null)
                return View(new ContactDetailsViewModel() { UserId = (int)Session["UserId"] });
            else
                return View(contact);
           
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
         public ActionResult Create(ContactDetailsViewModel contactDetailsViewModel)
        {
            if (ModelState.IsValid)
            {
                _contactDetailsManager.IsRegister(contactDetailsViewModel);
                return RedirectToAction("Create", "BankDetails");
         
            }

            return View(contactDetailsViewModel);
        }
    }
}