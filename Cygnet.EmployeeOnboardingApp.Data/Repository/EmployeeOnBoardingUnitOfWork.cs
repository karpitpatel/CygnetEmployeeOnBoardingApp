

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cygnet.EmployeeOnboardingApp.Core.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Data.Context;

namespace Cygnet.EmployeeOnboardingApp.Data.Repository
{

    public interface IEmployeeOnBoardingUnitOfWork : IUnitOfWork
    {
    }
  
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
