using AutoMapper;
using Cygnet.EmployeeOnboardingApp.Data.Model;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewMapping
{
    public class EducationMapping : BaseMapper<EducationViewModel, Education>
    {
        public EducationMapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // Configure AutoMapper
                cfg.CreateMap<EducationViewModel, Education>();
                cfg.CreateMap<Education, EducationViewModel>();
            });
            Mapper = config.CreateMapper();
        }
    }
}