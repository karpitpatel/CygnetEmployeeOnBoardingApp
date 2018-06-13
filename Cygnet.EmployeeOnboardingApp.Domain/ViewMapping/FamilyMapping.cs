using AutoMapper;
using Cygnet.EmployeeOnboardingApp.Data.Model;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewMapping
{
    public class FamilyMapping : BaseMapper<FamilyViewModel, Family>
    {
        public FamilyMapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // Configure AutoMapper
                cfg.CreateMap<FamilyViewModel, Family>();
                cfg.CreateMap<Family, FamilyViewModel>();
            });
            Mapper = config.CreateMapper();
        }
    }
}