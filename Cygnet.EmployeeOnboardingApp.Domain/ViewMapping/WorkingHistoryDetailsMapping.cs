using AutoMapper;
using Cygnet.EmployeeOnboardingApp.Data.Model;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewMapping
{
    public class WorkingHistoryDetailsMapping : BaseMapper<WorkingHistoryDetailsViewModel, WorkingHistoryDetails>
    {
        public WorkingHistoryDetailsMapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // Configure AutoMapper
                cfg.CreateMap<WorkingHistoryDetailsViewModel, WorkingHistoryDetails>();
                cfg.CreateMap<WorkingHistoryDetails, WorkingHistoryDetailsViewModel>();
            });
            Mapper = config.CreateMapper();
        }
    }
}