using Cygnet.EmployeeOnboardingApp.Domain.Manager;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using System.Web.Mvc;

namespace Cygnet.EmployeeOnboardingApp.Controllers
{
    public class BankDetailsController : Controller
    {
        private readonly IBankDetailsManager _bankDetailsManager;
        /*  public BankDetailsController()
          {
          }*/

        public BankDetailsController(IBankDetailsManager bankDetailsManager)
        {
            _bankDetailsManager = bankDetailsManager;
        }

        public ActionResult Create()
        {
            var bank = _bankDetailsManager.GetBankDetails((int)Session["EmpId"]);
            if (bank == null)
                return View(new BankDetailsViewModel() { UserId = (int)Session["EmpId"] });
            else
                return View(bank);
            //return View();
        }

        // POST: BankDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        // public ActionResult Create([Bind(Include = "Acc_No,Ifsc_Code,Pan_No,Uan_No,Ins_No,Mediclaim,Life_Ins,Fam_PensionScheme,Pf_No")] BankDetailsViewModel bankDetailsViewModel)
        public ActionResult Create(BankDetailsViewModel bankDetailsViewModel)
        {
            if (ModelState.IsValid)
            {
                _bankDetailsManager.IsRegister(bankDetailsViewModel);
                return RedirectToAction("Create", "AccomodationDetails");
                //return View();
            }

            return View(bankDetailsViewModel);
        }
    }
}