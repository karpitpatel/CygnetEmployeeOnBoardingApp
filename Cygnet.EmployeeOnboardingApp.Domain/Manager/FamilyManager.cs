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
    public interface IFamilyManager
    {
        List<FamilyViewModel> GetAllFamily(int UserId);
        FamilyViewModel GetFamily(int Id);
        void IsRegister(FamilyViewModel familyViewModel);
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
        public List<FamilyViewModel> GetAllFamily(int UserId)
        {
            var dataModelList = _familyRepository.GetAllFamily(UserId);
            return familyMapping.MapToViewList(dataModelList);

        }
        public FamilyViewModel GetFamily(int Id)
        {
            var dataModel = _familyRepository.GetFamily(Id);
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

