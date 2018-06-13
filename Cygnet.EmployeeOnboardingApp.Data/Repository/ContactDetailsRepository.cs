using Cygnet.EmployeeOnboardingApp.Core.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Data.Model;
using System.Collections.Generic;
using System.Linq;

namespace Cygnet.EmployeeOnboardingApp.Data.Repository
{
    public interface IContactDetailsRepository : IRepository<ContactDetails>
    {
        ContactDetails GetContactDetails(int EmpCode);

        ICollection<ContactDetails> GetContactDetails();

        void IsRegisterr(ContactDetails model);

        void IsUpdatee(ContactDetails model);
    }

    public class ContactDetailsRepository : BaseRepository<ContactDetails>, IContactDetailsRepository
    {
        public ContactDetailsRepository(IEmployeeOnBoardingUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        public ContactDetails GetContactDetails(int EmpCode)
        {
            return Get(_ => _.UserId == EmpCode).FirstOrDefault();
        }

        public ICollection<ContactDetails> GetContactDetails()
        {
            return Get().ToList();
        }

        public void IsRegisterr(ContactDetails model)
        {
            Insert(model);
        }

        public void IsUpdatee(ContactDetails model)
        {
            Update(model);
        }
    }
}