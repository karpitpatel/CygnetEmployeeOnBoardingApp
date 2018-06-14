using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cygnet.EmployeeOnboardingApp.Core.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Data.Model;


namespace Cygnet.EmployeeOnboardingApp.Data.Repository
{
    public interface IContactDetailsRepository : IRepository<ContactDetails>
    {
        ContactDetails GetContactDetails(int UserId);
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
        public ContactDetails GetContactDetails(int UserId)
        {
            return Get(_ => _.UserId == UserId).LastOrDefault();
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
