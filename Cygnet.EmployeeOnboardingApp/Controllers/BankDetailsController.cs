using Cygnet.EmployeeOnboardingApp.Domain.Manager;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using System.Web.Mvc;

namespace Cygnet.EmployeeOnboardingApp.Controllers
{
    public class BankDetailsController : Controller
    {
        private readonly IBankDetailsManager _bankDetailsManager;
        
        public BankDetailsController(IBankDetailsManager bankDetailsManager)
        {
            _bankDetailsManager = bankDetailsManager;
        }

        public ActionResult Create()
        {
            var bank = _bankDetailsManager.GetBankDetails((int)Session["UserId"]);
            if (bank == null)
                return View(new BankDetailsViewModel(){ UserId = (int)Session["UserId"]});
            else
                return View(bank);
            
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
      
        public ActionResult Create(BankDetailsViewModel bankDetailsViewModel)
        {
            if (ModelState.IsValid)
            {
                _bankDetailsManager.IsRegister(bankDetailsViewModel);
                return RedirectToAction("Create", "AccomodationDetails");
                ;
            }

            return View(bankDetailsViewModel);
        }
    }
}