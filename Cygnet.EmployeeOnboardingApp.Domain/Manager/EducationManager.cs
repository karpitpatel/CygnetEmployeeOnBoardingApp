using Cygnet.EmployeeOnboardingApp.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Domain.ViewMapping;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using System.Collections.Generic;

namespace Cygnet.EmployeeOnboardingApp.Domain.Manager
{
    public interface IEducationManager
    {
        List<EducationViewModel> GetAllEducation(int EmpCode);

        EducationViewModel GetEducation(int EmpCode);

        void IsRegister(EducationViewModel educationViewModel);

        // void GetEducation(int? id);
        void IsUpdate(EducationViewModel educationViewModel);
    }

    public class EducationManager : BaseManager, IEducationManager
    {
        private readonly IEducationRepository _educationRepository;
        private EducationMapping educationMapping;

        public EducationManager(IEducationRepository educationRepository)
        {
            _educationRepository = educationRepository;
            educationMapping = new EducationMapping();
        }

        public List<EducationViewModel> GetAllEducation(int EmpCode)
        {
            var dataModelList = _educationRepository.GetAllEducation(EmpCode);
            return educationMapping.MapToViewList(dataModelList);
        }

        public EducationViewModel GetEducation(int EmpCode)
        {
            var dataModel = _educationRepository.GetEducation(EmpCode);
            return educationMapping.MapToView(dataModel);
        }

        public void IsRegister(EducationViewModel educationViewModel)
        {
            _educationRepository.IsRegisterr(educationMapping.MapToModel(educationViewModel));
            _educationRepository.UnitOfWork.Save();
        }

        public void IsUpdate(EducationViewModel educationViewModel)
        {
            _educationRepository.IsUpdatee(educationMapping.MapToModel(educationViewModel));
            _educationRepository.UnitOfWork.Save();
        }
    }
}