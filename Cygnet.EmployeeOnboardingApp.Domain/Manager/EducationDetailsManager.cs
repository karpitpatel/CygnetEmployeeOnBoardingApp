using Cygnet.EmployeeOnboardingApp.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Domain.ViewMapping;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using System.Collections.Generic;

namespace Cygnet.EmployeeOnboardingApp.Domain.Manager
{
    public interface IEducationDetailsManager
    {
        List<EducationDetailsViewModel> GetAllEducationDetails();

        EducationDetailsViewModel GetEducationDetails(int EmpCode);

        void IsRegister(EducationDetailsViewModel educationDetailsViewModel);

        // void GetEducationDetails(int? id);
        void IsUpdate(EducationDetailsViewModel educationDetailsViewModel);
    }

    public class EducationDetailsManager : BaseManager, IEducationDetailsManager
    {
        private readonly IEducationDetailsRepository _educationDetailsRepository;
        private EducationDetailsMapping educationDetailsMapping;

        public EducationDetailsManager(IEducationDetailsRepository educationDetailsRepository)
        {
            _educationDetailsRepository = educationDetailsRepository;
            educationDetailsMapping = new EducationDetailsMapping();
        }

        public List<EducationDetailsViewModel> GetAllEducationDetails()
        {
            var dataModelList = _educationDetailsRepository.GetEducationDetails();
            return educationDetailsMapping.MapToViewList(dataModelList);
        }

        public EducationDetailsViewModel GetEducationDetails(int EmpCode)
        {
            var dataModel = _educationDetailsRepository.GetEducationDetails(EmpCode);
            return educationDetailsMapping.MapToView(dataModel);
        }

        public void IsRegister(EducationDetailsViewModel educationDetailsViewModel)
        {
            _educationDetailsRepository.IsRegisterr(educationDetailsMapping.MapToModel(educationDetailsViewModel));
            _educationDetailsRepository.UnitOfWork.Save();
        }

        public void IsUpdate(EducationDetailsViewModel educationDetailsViewModel)
        {
            _educationDetailsRepository.IsUpdatee(educationDetailsMapping.MapToModel(educationDetailsViewModel));
            _educationDetailsRepository.UnitOfWork.Save();
        }
    }
}