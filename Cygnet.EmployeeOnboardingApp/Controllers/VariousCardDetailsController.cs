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
            var variousCard = _variousCardDetailsManager.GetVariousCardDetails((int)Session["EmpId"]);
            if (variousCard == null)
                return View(new VariousCardDetailsViewModel() { UserId = (int)Session["EmpId"] });
            else
                return View(variousCard);
            //return View();
        }

        // POST: VariousCardDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //  public ActionResult Create([Bind(Include = "Passport_No,Passport_Validity,Esic_No,Vehicle_No,Pension_Payment_OrderNo,Scheme_Certificate_No,Aadhar_No,Election_No")] VariousCardDetailsViewModel variousCardDetailsViewModel)
        public ActionResult Create(VariousCardDetailsViewModel variousCardDetailsViewModel)
        {
            if (ModelState.IsValid)
            {
                _variousCardDetailsManager.IsRegister(variousCardDetailsViewModel);
                return RedirectToAction("Index", "Family");
                // return View();
            }

            return View(variousCardDetailsViewModel);
        }
    }
}