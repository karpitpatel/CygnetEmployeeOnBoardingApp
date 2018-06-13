using Cygnet.EmployeeOnboardingApp.Core.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Data.Model;
using System.Collections.Generic;
using System.Linq;

namespace Cygnet.EmployeeOnboardingApp.Data.Repository
{
    public interface IFamilyDetailsRepository : IRepository<FamilyDetails>
    {
        FamilyDetails GetFamilyDetails(int EmpCode);

        ICollection<FamilyDetails> GetFamilyDetails();

        void IsRegisterr(FamilyDetails model);

        void IsUpdatee(FamilyDetails model);
    }

    public class FamilyDetailsRepository : BaseRepository<FamilyDetails>, IFamilyDetailsRepository
    {
        public FamilyDetailsRepository(IEmployeeOnBoardingUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        public FamilyDetails GetFamilyDetails(int EmpCode)
        {
            return Get(_ => _.UserId == EmpCode).FirstOrDefault();
        }

        public ICollection<FamilyDetails> GetFamilyDetails()
        {
            return Get().ToList();
        }

        public void IsRegisterr(FamilyDetails model)
        {
            // if (model.Email != null && model.Password != null)
            //    return Update(model).ToList();
            Insert(model);
        }

        public void IsUpdatee(FamilyDetails model)
        {
            Update(model);
        }
    }
}