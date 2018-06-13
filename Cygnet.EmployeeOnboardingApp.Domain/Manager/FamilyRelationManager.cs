using Cygnet.EmployeeOnboardingApp.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Domain.ViewMapping;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using System.Collections.Generic;

namespace Cygnet.EmployeeOnboardingApp.Domain.Manager
{
    public interface IFamilyRelationManager
    {
        List<FamilyRelationViewModel> GetAllFamilyRelation();

        FamilyRelationViewModel GetFamilyRelation(int EmpCode);

        // FamilyRelationViewModel GetFamilyRelation(FamilyRelationViewModel familyRelationViewModel);
    }

    public class FamilyRelationManager : BaseManager, IFamilyRelationManager
    {
        private readonly IFamilyRelationRepository _familyRelationRepository;
        private FamilyRelationMapping familyRelationMapping;

        public FamilyRelationManager(IFamilyRelationRepository familyRelationRepository)
        {
            _familyRelationRepository = familyRelationRepository;
            familyRelationMapping = new FamilyRelationMapping();
        }

        public List<FamilyRelationViewModel> GetAllFamilyRelation()
        {
            var dataModelList = _familyRelationRepository.GetFamilyRelation();
            return familyRelationMapping.MapToViewList(dataModelList);
        }

        public FamilyRelationViewModel GetFamilyRelation(int EmpCode)
        {
            var dataModel = _familyRelationRepository.GetFamilyRelation(EmpCode);
            return familyRelationMapping.MapToView(dataModel);
        }
    }
}