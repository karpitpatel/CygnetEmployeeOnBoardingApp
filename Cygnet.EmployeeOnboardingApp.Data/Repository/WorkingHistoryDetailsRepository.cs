using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cygnet.EmployeeOnboardingApp.Core.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Repository
{
    public interface IWorkingHistoryDetailsRepository : IRepository<WorkingHistoryDetails>
    {
        WorkingHistoryDetails GetWorkingHistoryDetails(int UserId);
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
        public WorkingHistoryDetails GetWorkingHistoryDetails(int UserId)
        {
            return Get(_ => _.UserId == UserId).LastOrDefault();
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
