using Cygnet.EmployeeOnboardingApp.Domain.Manager;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using System.Web.Mvc;

namespace Cygnet.EmployeeOnboardingApp.Controllers
{
    public class WorkingHistoryDetailsController : Controller
    {
        private readonly IWorkingHistoryDetailsManager _workingHistoryDetailsManager;

        public WorkingHistoryDetailsController(IWorkingHistoryDetailsManager workingHistoryDetailsManager)
        {
            _workingHistoryDetailsManager = workingHistoryDetailsManager;
        }

        public ActionResult Create()
        {
            var workingHistoryDetails = _workingHistoryDetailsManager.GetWorkingHistoryDetails((int)Session["UserId"]);
            if (workingHistoryDetails == null)
                return View(new WorkingHistoryDetailsViewModel() { UserId = (int)Session["UserId"] });
            else
                return View(workingHistoryDetails);

        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(WorkingHistoryDetailsViewModel workingHistoryDetailsViewModel)
        {
            if (ModelState.IsValid)
            {
                _workingHistoryDetailsManager.IsRegister(workingHistoryDetailsViewModel);
                return RedirectToAction("Create", "VariousCardDetails");

            }

            return View(workingHistoryDetailsViewModel);
        }
    }
}