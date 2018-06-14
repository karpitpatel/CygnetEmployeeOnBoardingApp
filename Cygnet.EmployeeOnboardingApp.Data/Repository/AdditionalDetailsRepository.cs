using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cygnet.EmployeeOnboardingApp.Core.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Repository
{
    public interface IAdditionalDetailsRepository : IRepository<AdditionalDetails>
    {
        AdditionalDetails GetAdditionalDetails(int UserId);
        ICollection<AdditionalDetails> GetAdditionalDetails();
        void IsRegisterr(AdditionalDetails model);
        void IsUpdatee(AdditionalDetails model);
    }
    public class AdditionalDetailsRepository : BaseRepository<AdditionalDetails>, IAdditionalDetailsRepository
    {
        public AdditionalDetailsRepository(IEmployeeOnBoardingUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
        public AdditionalDetails GetAdditionalDetails(int UserId)
        {
            return Get(_ => _.UserId == UserId).FirstOrDefault();
        }
        public ICollection<AdditionalDetails> GetAdditionalDetails()
        {
            return Get().ToList();
        }
        public void IsRegisterr(AdditionalDetails model)
        {
            Insert(model);
        }
        public void IsUpdatee(AdditionalDetails model)
        {
            Update(model);
        }
    }
}
