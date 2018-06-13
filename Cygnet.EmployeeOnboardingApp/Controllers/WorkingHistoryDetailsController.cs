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
            var workingHistoryDetails = _workingHistoryDetailsManager.GetWorkingHistoryDetails((int)Session["EmpId"]);
            if (workingHistoryDetails == null)
                return View(new WorkingHistoryDetailsViewModel() { UserId = (int)Session["EmpId"] });
            else
                return View(workingHistoryDetails);
            //return View();
        }

        // POST: WorkingHistoryDetailsDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        // public ActionResult Create([Bind(Include = "Name_Company,Addr_Company,Designation,Department,Designation_Person_ReportingTo,Doj,Dol,Monthly_Gross_Salary,Pension_No,Reason_For_Leaving,Detailed_By,Reporting_To,Ctc_Perannum,Ref1_Name,Ref1_Phn,Ref1_Addr,Ref2_Name,Ref2_Phn,Ref2_Addr")] WorkingHistoryDetailsViewModel workingHistoryDetailsViewModel)
        public ActionResult Create(WorkingHistoryDetailsViewModel workingHistoryDetailsViewModel)
        {
            if (ModelState.IsValid)
            {
                _workingHistoryDetailsManager.IsRegister(workingHistoryDetailsViewModel);
                return RedirectToAction("Create", "VariousCardDetails");
                //  return View();
            }

            return View(workingHistoryDetailsViewModel);
        }
    }
}