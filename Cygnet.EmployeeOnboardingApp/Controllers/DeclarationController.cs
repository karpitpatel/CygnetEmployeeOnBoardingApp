using Cygnet.EmployeeOnboardingApp.Domain.Manager;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using System.Web.Mvc;

namespace Cygnet.EmployeeOnboardingApp.Controllers
{
    public class DeclarationController : Controller
    {
        private readonly IDeclarationManager _declarationManager;

        public DeclarationController(IDeclarationManager declarationManager)
        {
            _declarationManager = declarationManager;
        }

    

       
        public ActionResult Create()
        {
            var declaration = _declarationManager.GetDeclaration((int)Session["UserId"]);
            if (declaration == null)
                return View(new DeclarationViewModel() { UserId = (int)Session["UserId"] });
            else
                return View(declaration);
            
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
     
        public ActionResult Create(DeclarationViewModel declarationViewModel)
        {
            if (ModelState.IsValid)
            {
                _declarationManager.IsRegister(declarationViewModel);
                return RedirectToAction("Create", "NomineeDetails");
               
            }

            return View(declarationViewModel);
        }

       
    }
}