using Cygnet.EmployeeOnboardingApp.Domain.Manager;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using System.Web.Mvc;

//using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;

namespace Cygnet.EmployeeOnboardingApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserManager _userManager;

        public AccountController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var data = _userManager.UserLogin(model.Email, model.Password);
                //   Session["EmpId"] = data.Id;
                if (data != null)
                {
                    Session["EmpId"] = data.Id;
                    return View("WelcomePage");
                }
                else
                    return View();
                //  return RedirectToAction("Login");
            }
            // return RedirectToAction("Login");
            return View();
        }

        public ActionResult ThankYouPage()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            //User user = new User();
            // return View(user);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        // public ActionResult Create([Bind(Include = "Name,Email,Password")]UserViewModel userViewModel)
        public ActionResult Create(UserViewModel userViewModel)
        {
            //  user = new User();
            if (ModelState.IsValid)
            {
                _userManager.Isfield(userViewModel);
                return RedirectToAction("Login");
            }

            // return View("Login");
            return View();
        }

        [HttpGet]
        public ActionResult WelcomePage()
        {
            UserViewModel model = new UserViewModel();

            return View();
        }
    }
}