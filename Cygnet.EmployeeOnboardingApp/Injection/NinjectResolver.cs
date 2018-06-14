using Cygnet.EmployeeOnboardingApp.Data.Context;
using Cygnet.EmployeeOnboardingApp.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Domain.Manager;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cygnet.EmployeeOnboardingApp.Injection
{
    public class NinjectResolver : System.Web.Mvc.IDependencyResolver
    {
        private readonly IKernel _kernel;

        public NinjectResolver()
        {
            _kernel = new StandardKernel();
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            _kernel.Bind<IEmployeeOnBoardingEntities>().To<EmployeeOnBoardingEntities>();
            _kernel.Bind<IEmployeeOnBoardingUnitOfWork>().To<EmployeeOnBoardingUnitOfWork>();
            _kernel.Bind<ITestUOWManager>().To<TestUOWManager>();
            _kernel.Bind<IUserManager>().To<UserManager>();
            _kernel.Bind<IPersonalDetailsManager>().To<PersonalDetailsManager>();
            _kernel.Bind<IContactDetailsManager>().To<ContactDetailsManager>();
            _kernel.Bind<IBankDetailsManager>().To<BankDetailsManager>();
            _kernel.Bind<IAccomodationDetailsManager>().To<AccomodationDetailsManager>();
            _kernel.Bind<IAdditionalDetailsManager>().To<AdditionalDetailsManager>();
            _kernel.Bind<IOriginDetailsManager>().To<OriginDetailsManager>();
            _kernel.Bind<INomineeDetailsManager>().To<NomineeDetailsManager>();
            _kernel.Bind<IWorkingHistoryDetailsManager>().To<WorkingHistoryDetailsManager>();
            _kernel.Bind<IVariousCardDetailsManager>().To<VariousCardDetailsManager>();
            _kernel.Bind<IDeclarationManager>().To<DeclarationManager>();
            _kernel.Bind<IFamilyManager>().To<FamilyManager>();
            _kernel.Bind<IEducationManager>().To<EducationManager>();





            _kernel.Bind<ITestUOWRepository>().To<TestUOWRepository>();
            _kernel.Bind<IUserRepository>().To<UserRepository>();
            _kernel.Bind<IPersonalDetailsRepository>().To<PersonalDetailsRepository>();
            _kernel.Bind<IContactDetailsRepository>().To<ContactDetailsRepository>();
            _kernel.Bind<IBankDetailsRepository>().To<BankDetailsRepository>();
            _kernel.Bind<IAdditionalDetailsRepository>().To<AdditionalDetailsRepository>();
            _kernel.Bind<IAccomodationDetailsRepository>().To<AccomodationDetailsRepository>();
            _kernel.Bind<IOriginDetailsRepository>().To<OriginDetailsRepository>();
            _kernel.Bind<IWorkingHistoryDetailsRepository>().To<WorkingHistoryDetailsRepository>();
            _kernel.Bind<IVariousCardDetailsRepository>().To<VariousCardDetailsRepository>();
            _kernel.Bind<IDeclarationRepository>().To<DeclarationRepository>();
            _kernel.Bind<INomineeDetailsRepository>().To<NomineeDetailsRepository>();
            _kernel.Bind<IFamilyRepository>().To<FamilyRepository>();
            _kernel.Bind<IEducationRepository>().To<EducationRepository>();



        }
    }
}