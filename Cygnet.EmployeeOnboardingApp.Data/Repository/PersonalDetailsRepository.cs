using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cygnet.EmployeeOnboardingApp.Core.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Repository
{
    public interface IPersonalDetailsRepository : IRepository<PersonalDetails>
    {
        PersonalDetails GetPersonalDetails(int UserId);
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
        public PersonalDetails GetPersonalDetails(int UserId)
        {
            return Get(_ => _.UserId == UserId).FirstOrDefault();
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
