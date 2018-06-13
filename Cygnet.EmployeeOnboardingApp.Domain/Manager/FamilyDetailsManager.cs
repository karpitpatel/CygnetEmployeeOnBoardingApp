using Cygnet.EmployeeOnboardingApp.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Domain.ViewMapping;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using System.Collections.Generic;

namespace Cygnet.EmployeeOnboardingApp.Domain.Manager
{
    public interface IFamilyDetailsManager
    {
        List<FamilyDetailsViewModel> GetAllFamilyDetails();

        FamilyDetailsViewModel GetFamilyDetails(int EmpCode);

        void IsRegister(FamilyDetailsViewModel familyDetailsViewModel);

        // void GetFamilyDetails(int? id);
        void IsUpdate(FamilyDetailsViewModel familyDetailsViewModel);
    }

    public class FamilyDetailsManager : BaseManager, IFamilyDetailsManager
    {
        private readonly IFamilyDetailsRepository _familyDetailsRepository;
        private FamilyDetailsMapping familyDetailsMapping;

        public FamilyDetailsManager(IFamilyDetailsRepository familyDetailsRepository)
        {
            _familyDetailsRepository = familyDetailsRepository;
            familyDetailsMapping = new FamilyDetailsMapping();
        }

        public List<FamilyDetailsViewModel> GetAllFamilyDetails()
        {
            var dataModelList = _familyDetailsRepository.GetFamilyDetails();
            return familyDetailsMapping.MapToViewList(dataModelList);
        }

        public FamilyDetailsViewModel GetFamilyDetails(int EmpCode)
        {
            var dataModel = _familyDetailsRepository.GetFamilyDetails(EmpCode);
            return familyDetailsMapping.MapToView(dataModel);
        }

        public void IsRegister(FamilyDetailsViewModel familyDetailsViewModel)
        {
            _familyDetailsRepository.IsRegisterr(familyDetailsMapping.MapToModel(familyDetailsViewModel));
            _familyDetailsRepository.UnitOfWork.Save();
        }

        public void IsUpdate(FamilyDetailsViewModel familyDetailsViewModel)
        {
            _familyDetailsRepository.IsUpdatee(familyDetailsMapping.MapToModel(familyDetailsViewModel));
            _familyDetailsRepository.UnitOfWork.Save();
        }
    }
}