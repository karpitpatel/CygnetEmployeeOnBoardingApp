using Cygnet.EmployeeOnboardingApp.Core.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Data.Model;
using System.Collections.Generic;
using System.Linq;

namespace Cygnet.EmployeeOnboardingApp.Data.Repository
{
    public interface IWorkingHistoryDetailsRepository : IRepository<WorkingHistoryDetails>
    {
        WorkingHistoryDetails GetWorkingHistoryDetails(int EmpCode);

        ICollection<WorkingHistoryDetails> GetWorkingHistoryDetails();

        void IsRegisterr(WorkingHistoryDetails model);

        void IsUpdatee(WorkingHistoryDetails model);
    }

    public class WorkingHistoryDetailsRepository : BaseRepository<WorkingHistoryDetails>, IWorkingHistoryDetailsRepository
    {
        public WorkingHistoryDetailsRepository(IEmployeeOnBoardingUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        public WorkingHistoryDetails GetWorkingHistoryDetails(int EmpCode)
        {
            return Get(_ => _.UserId == EmpCode).FirstOrDefault();
        }

        public ICollection<WorkingHistoryDetails> GetWorkingHistoryDetails()
        {
            return Get().ToList();
        }

        public void IsRegisterr(WorkingHistoryDetails model)
        {
            Insert(model);
        }

        public void IsUpdatee(WorkingHistoryDetails model)
        {
            Update(model);
        }
    }
}