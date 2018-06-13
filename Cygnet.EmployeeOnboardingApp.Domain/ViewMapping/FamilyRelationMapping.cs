using AutoMapper;
using Cygnet.EmployeeOnboardingApp.Data.Model;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewMapping
{
    public class FamilyRelationMapping : BaseMapper<FamilyRelationViewModel, FamilyRelation>
    {
        public FamilyRelationMapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // Configure AutoMapper
                cfg.CreateMap<FamilyRelationViewModel, FamilyRelation>();
                cfg.CreateMap<FamilyRelation, FamilyRelationViewModel>();
            });
            Mapper = config.CreateMapper();
        }
    }
}