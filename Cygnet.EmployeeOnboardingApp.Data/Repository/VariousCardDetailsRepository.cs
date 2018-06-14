using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cygnet.EmployeeOnboardingApp.Core.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Repository
{
    public interface IVariousCardDetailsRepository : IRepository<VariousCardDetails>
    {
        VariousCardDetails GetVariousCardDetails(int UserId);
        ICollection<VariousCardDetails> GetVariousCardDetails();
        void IsRegisterr(VariousCardDetails model);
        void IsUpdatee(VariousCardDetails model);
    }
    public class VariousCardDetailsRepository : BaseRepository<VariousCardDetails>, IVariousCardDetailsRepository
    {
        public VariousCardDetailsRepository(IEmployeeOnBoardingUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
        public VariousCardDetails GetVariousCardDetails(int UserId)
        {
            return Get(_ => _.UserId == UserId).LastOrDefault();
        }
        public ICollection<VariousCardDetails> GetVariousCardDetails()
        {
            return Get().ToList();
        }
        public void IsRegisterr(VariousCardDetails model)
        {
            Insert(model);
        }
        public void IsUpdatee(VariousCardDetails model)
        {
            Update(model);
        }
    }
}
