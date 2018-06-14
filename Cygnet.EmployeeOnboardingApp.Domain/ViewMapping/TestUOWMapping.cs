using AutoMapper;
using Cygnet.EmployeeOnboardingApp.Data.Model;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewMapping
{
    public class TestUOWMapping : BaseMapper<TestUOWViewModel, TestUOW>
    {
        public TestUOWMapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // Configure AutoMapper
                cfg.CreateMap<TestUOWViewModel, TestUOW>();
                cfg.CreateMap<TestUOW, TestUOWViewModel>();
            });
            Mapper = config.CreateMapper();
        }
    }
}