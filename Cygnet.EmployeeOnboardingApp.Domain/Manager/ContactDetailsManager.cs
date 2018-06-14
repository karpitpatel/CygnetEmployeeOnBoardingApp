using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Cygnet.EmployeeOnboardingApp.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Domain.ViewMapping;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;

namespace Cygnet.EmployeeOnboardingApp.Domain.Manager
{
    public interface IContactDetailsManager
    {
        List<ContactDetailsViewModel> GetAllContactDetails();
         ContactDetailsViewModel GetContactDetails(int UserId);
       
        void IsRegister(ContactDetailsViewModel contactDetailsViewModel);
 
        void IsUpdate(ContactDetailsViewModel contactDetailsViewModel);
    }
    public class ContactDetailsManager : BaseManager, IContactDetailsManager
    {
        private readonly IContactDetailsRepository _contactDetailsRepository;
        private ContactDetailsMapping contactDetailsMapping;

        public ContactDetailsManager(IContactDetailsRepository contactDetailsRepository)
        {
            _contactDetailsRepository = contactDetailsRepository;
            contactDetailsMapping = new ContactDetailsMapping();

        }
        public List<ContactDetailsViewModel> GetAllContactDetails()
        {
            var dataModelList = _contactDetailsRepository.GetContactDetails();
            return contactDetailsMapping.MapToViewList(dataModelList);

        }
        public ContactDetailsViewModel GetContactDetails(int UserId)
        {
            var dataModel = _contactDetailsRepository.GetContactDetails(UserId);
            return contactDetailsMapping.MapToView(dataModel);

        }
        public void IsRegister(ContactDetailsViewModel contactDetailsViewModel)
        {
            _contactDetailsRepository.IsRegisterr(contactDetailsMapping.MapToModel(contactDetailsViewModel));
            _contactDetailsRepository.UnitOfWork.Save();

        }
        public void IsUpdate(ContactDetailsViewModel contactDetailsViewModel)
        {
            _contactDetailsRepository.IsUpdatee(contactDetailsMapping.MapToModel(contactDetailsViewModel));
            _contactDetailsRepository.UnitOfWork.Save();

        }
    }
}

