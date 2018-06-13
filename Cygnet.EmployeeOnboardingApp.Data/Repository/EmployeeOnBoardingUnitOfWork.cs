using Cygnet.EmployeeOnboardingApp.Core.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Data.Context;

namespace Cygnet.EmployeeOnboardingApp.Data.Repository
{
    public interface IEmployeeOnBoardingUnitOfWork : IUnitOfWork
    {
    }

    /// <summary>
    /// An extension of UnitOfWork that specifically uses an instance of ITestUOWEntities,
    /// and forms the basis of all repositories that work with common data.
    /// </summary>
    public class EmployeeOnBoardingUnitOfWork : UnitOfWork<IEmployeeOnBoardingEntities>, IEmployeeOnBoardingUnitOfWork
    {
        public EmployeeOnBoardingUnitOfWork(IEmployeeOnBoardingEntities context)
            : base(context)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}