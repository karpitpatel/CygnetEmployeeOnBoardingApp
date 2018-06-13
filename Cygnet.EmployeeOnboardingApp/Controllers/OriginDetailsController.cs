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
            var originDetails = _originDetailsManager.GetOriginDetails((int)Session["EmpId"]);
            if (originDetails == null)
                return View(new OriginDetailsViewModel() { UserId = (int)Session["EmpId"] });
            else
                return View(originDetails);
            //return View();
        }

        // POST: OriginDetailsDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Is_International_Worker,Country_Origin")] OriginDetailsViewModel originDetailsViewModel)
        public ActionResult Create(OriginDetailsViewModel originDetailsViewModel)
        {
            if (ModelState.IsValid)
            {
                _originDetailsManager.IsRegister(originDetailsViewModel);
                return RedirectToAction("Create", "WorkingHistoryDetails");
                //return View();
            }

            return View(originDetailsViewModel);
        }
    }
}