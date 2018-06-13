using AutoMapper;
using Cygnet.EmployeeOnboardingApp.Data.Model;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewMapping
{
    public class UserMapping : BaseMapper<UserViewModel, User>
    {
        public UserMapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // Configure AutoMapper
                cfg.CreateMap<UserViewModel, User>();
                cfg.CreateMap<User, UserViewModel>();
            });
            Mapper = config.CreateMapper();
        }
    }
}