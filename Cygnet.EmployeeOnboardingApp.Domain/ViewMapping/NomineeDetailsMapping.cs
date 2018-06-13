using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Cygnet.EmployeeOnboardingApp.Data.Model;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewMapping
{

    public class NomineeDetailsMapping : BaseMapper<NomineeDetailsViewModel, NomineeDetails>
    {
        public NomineeDetailsMapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // Configure AutoMapper
                cfg.CreateMap<NomineeDetailsViewModel, NomineeDetails>();
                cfg.CreateMap<NomineeDetails, NomineeDetailsViewModel>();
            });
            Mapper = config.CreateMapper();
        }

    }
}

  