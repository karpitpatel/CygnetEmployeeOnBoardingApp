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
            var contact = _contactDetailsManager.GetContactDetails((int)Session["EmpId"]);
            if (contact == null)
                return View(new ContactDetailsViewModel() { UserId = (int)Session["EmpId"] });
            else
                return View(contact);
            //return View();
        }

        // POST: ContactDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //   public ActionResult Create([Bind(Include = "Email,HomeNo,MobNo,TempAddr,PermAddr,Pincode_tempaddr,Pincode_permadrr,Created,Modified,RowVersion")] ContactDetailsViewModel contactDetailsViewModel)
        public ActionResult Create(ContactDetailsViewModel contactDetailsViewModel)
        {
            if (ModelState.IsValid)
            {
                _contactDetailsManager.IsRegister(contactDetailsViewModel);
                return RedirectToAction("Create", "BankDetails");
                //   return View();
            }

            return View(contactDetailsViewModel);
        }
    }
}