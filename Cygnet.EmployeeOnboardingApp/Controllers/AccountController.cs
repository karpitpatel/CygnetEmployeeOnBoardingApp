using Cygnet.EmployeeOnboardingApp.Domain.Manager;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using System.Web.Mvc;



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

                if (data != null)
                {
                    Session["UserId"] = data.Id;
                    return View("WelcomePage");
                }
                else
                    return View();

            }

            return View();
        }

        public ActionResult ThankYouPage()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(UserViewModel userViewModel)
        {

            if (ModelState.IsValid)
            {
                _userManager.IsRegister(userViewModel);
                return RedirectToAction("Login");
            }


            return View();
        }

        [HttpGet]
        public ActionResult WelcomePage()
        {
            UserViewModel model = new UserViewModel();

            return View();
        }
        //public ActionResult Logout()
        //{
        //    Session["UserId"] = null;
        //    return RedirectToAction("Login");

        //}
    }
}