using Cygnet.EmployeeOnboardingApp.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Domain.ViewMapping;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using System.Collections.Generic;

namespace Cygnet.EmployeeOnboardingApp.Domain.Manager
{
    public interface IFamilyManager
    {
        List<FamilyViewModel> GetAllFamily(int EmpCode);

        FamilyViewModel GetFamily(int EmpCode);

        void IsRegister(FamilyViewModel familyViewModel);

        // void GetFamily(int? id);
        void IsUpdate(FamilyViewModel familyViewModel);
    }

    public class FamilyManager : BaseManager, IFamilyManager
    {
        private readonly IFamilyRepository _familyRepository;
        private FamilyMapping familyMapping;

        public FamilyManager(IFamilyRepository familyRepository)
        {
            _familyRepository = familyRepository;
            familyMapping = new FamilyMapping();
        }

        public List<FamilyViewModel> GetAllFamily(int EmpCode)
        {
            var dataModelList = _familyRepository.GetAllFamily(EmpCode);
            return familyMapping.MapToViewList(dataModelList);
        }

        public FamilyViewModel GetFamily(int EmpCode)
        {
            var dataModel = _familyRepository.GetFamily(EmpCode);
            return familyMapping.MapToView(dataModel);
        }

        public void IsRegister(FamilyViewModel familyViewModel)
        {
            _familyRepository.IsRegisterr(familyMapping.MapToModel(familyViewModel));
            _familyRepository.UnitOfWork.Save();
        }

        public void IsUpdate(FamilyViewModel familyViewModel)
        {
            _familyRepository.IsUpdatee(familyMapping.MapToModel(familyViewModel));
            _familyRepository.UnitOfWork.Save();
        }
    }
}