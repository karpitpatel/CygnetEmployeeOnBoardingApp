using Cygnet.EmployeeOnboardingApp.Core.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Data.Model;
using System.Collections.Generic;
using System.Linq;

namespace Cygnet.EmployeeOnboardingApp.Data.Repository
{
    public interface IEducationDetailsRepository : IRepository<EducationDetails>
    {
        EducationDetails GetEducationDetails(int EmpCode);

        ICollection<EducationDetails> GetEducationDetails();

        void IsRegisterr(EducationDetails model);

        void IsUpdatee(EducationDetails model);
    }

    public class EducationDetailsRepository : BaseRepository<EducationDetails>, IEducationDetailsRepository
    {
        public EducationDetailsRepository(IEmployeeOnBoardingUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        public EducationDetails GetEducationDetails(int EmpCode)
        {
            return Get(_ => _.UserId == EmpCode).FirstOrDefault();
        }

        public ICollection<EducationDetails> GetEducationDetails()
        {
            return Get().ToList();
        }

        public void IsRegisterr(EducationDetails model)
        {
            // if (model.Email != null && model.Password != null)
            //    return Update(model).ToList();
            Insert(model);
        }

        public void IsUpdatee(EducationDetails model)
        {
            Update(model);
        }
    }
}