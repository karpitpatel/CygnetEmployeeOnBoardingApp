using Cygnet.EmployeeOnboardingApp.Core.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Data.Model;
using System.Collections.Generic;
using System.Linq;

namespace Cygnet.EmployeeOnboardingApp.Data.Repository
{
    public interface IPersonalDetailsRepository : IRepository<PersonalDetails>
    {
        PersonalDetails GetPersonalDetails(int EmpCode);

        ICollection<PersonalDetails> GetPersonalDetails();

        void IsRegisterr(PersonalDetails model);

        void IsUpdatee(PersonalDetails model);
    }

    public class PersonalDetailsRepository : BaseRepository<PersonalDetails>, IPersonalDetailsRepository
    {
        public PersonalDetailsRepository(IEmployeeOnBoardingUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        public PersonalDetails GetPersonalDetails(int EmpCode)
        {
            return Get(_ => _.UserId == EmpCode).FirstOrDefault();
        }

        public ICollection<PersonalDetails> GetPersonalDetails()
        {
            return Get().ToList();
        }

        public void IsRegisterr(PersonalDetails model)
        {
            Insert(model);
        }

        public void IsUpdatee(PersonalDetails model)
        {
            Update(model);
        }
    }
}