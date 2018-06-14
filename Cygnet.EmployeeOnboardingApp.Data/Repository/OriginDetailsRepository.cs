using Cygnet.EmployeeOnboardingApp.Core.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Data.Model;
using System.Collections.Generic;
using System.Linq;

namespace Cygnet.EmployeeOnboardingApp.Data.Repository
{
    public interface IOriginDetailsRepository : IRepository<OriginDetails>
    {
        OriginDetails GetOriginDetails(int EmpCode);

        ICollection<OriginDetails> GetOriginDetails();

        void IsRegisterr(OriginDetails model);

        void IsUpdatee(OriginDetails model);
    }

    public class OriginDetailsRepository : BaseRepository<OriginDetails>, IOriginDetailsRepository
    {
        public OriginDetailsRepository(IEmployeeOnBoardingUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        public OriginDetails GetOriginDetails(int EmpCode)
        {
            return Get(_ => _.UserId == EmpCode).LastOrDefault();
        }

        public ICollection<OriginDetails> GetOriginDetails()
        {
            return Get().ToList();
        }

        public void IsRegisterr(OriginDetails model)
        {
            Insert(model);
        }

        public void IsUpdatee(OriginDetails model)
        {
            Update(model);
        }
    }
}