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
    public interface IEducationRelationManager
    {
        List<EducationRelationViewModel> GetAllEducationRelation();
        EducationRelationViewModel GetEducationRelation(int EmpCode);
        // EducationRelationViewModel GetEducationRelation(EducationRelationViewModel educationRelationViewModel);

    }
    public class EducationRelationManager : BaseManager, IEducationRelationManager
    {
        private readonly IEducationRelationRepository _educationRelationRepository;
        private EducationRelationMapping educationRelationMapping;

        public EducationRelationManager(IEducationRelationRepository educationRelationRepository)
        {
            _educationRelationRepository = educationRelationRepository;
            educationRelationMapping = new EducationRelationMapping();

        }
        public List<EducationRelationViewModel> GetAllEducationRelation()
        {
            var dataModelList = _educationRelationRepository.GetEducationRelation();
            return educationRelationMapping.MapToViewList(dataModelList);

        }
        public EducationRelationViewModel GetEducationRelation(int EmpCode)
        {
            var dataModel = _educationRelationRepository.GetEducationRelation(EmpCode);
            return educationRelationMapping.MapToView(dataModel);

        }

    }
}

