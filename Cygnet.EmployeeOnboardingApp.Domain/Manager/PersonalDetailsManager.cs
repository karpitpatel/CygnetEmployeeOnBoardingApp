using Cygnet.EmployeeOnboardingApp.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Domain.ViewMapping;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using System.Collections.Generic;

namespace Cygnet.EmployeeOnboardingApp.Domain.Manager
{
    public interface IPersonalDetailsManager
    {
        List<PersonalDetailsViewModel> GetAllPersonalDetails();
        PersonalDetailsViewModel GetPersonalDetails(int UserId);

        void IsRegister(PersonalDetailsViewModel personalDetailsViewModel);
        
        void IsUpdate(PersonalDetailsViewModel personalDetailsViewModel);
    }

    public class PersonalDetailsManager : BaseManager, IPersonalDetailsManager
    {
        private readonly IPersonalDetailsRepository _personalDetailsRepository;
        private PersonalDetailsMapping personalDetailsMapping;

        public PersonalDetailsManager(IPersonalDetailsRepository personalDetailsRepository)
        {
            _personalDetailsRepository = personalDetailsRepository;
            personalDetailsMapping = new PersonalDetailsMapping();
        }

        public List<PersonalDetailsViewModel> GetAllPersonalDetails()
        {
            var dataModelList = _personalDetailsRepository.GetPersonalDetails();
            return personalDetailsMapping.MapToViewList(dataModelList);
        }

        public PersonalDetailsViewModel GetPersonalDetails(int UserId)
        {
            var dataModel = _personalDetailsRepository.GetPersonalDetails(UserId);
            return personalDetailsMapping.MapToView(dataModel);
        }

        public void IsRegister(PersonalDetailsViewModel personalDetailsViewModel)
        {
            _personalDetailsRepository.IsRegisterr(personalDetailsMapping.MapToModel(personalDetailsViewModel));
            _personalDetailsRepository.UnitOfWork.Save();
        }

        public void IsUpdate(PersonalDetailsViewModel personalDetailsViewModel)
        {
            _personalDetailsRepository.IsUpdatee(personalDetailsMapping.MapToModel(personalDetailsViewModel));
            _personalDetailsRepository.UnitOfWork.Save();
        }
    }
}