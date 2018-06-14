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

    public class AccomodationDetailsMapping : BaseMapper<AccomodationDetailsViewModel, AccomodationDetails>
    {
        public AccomodationDetailsMapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // Configure AutoMapper
                cfg.CreateMap<AccomodationDetailsViewModel, AccomodationDetails>();
                cfg.CreateMap<AccomodationDetails, AccomodationDetailsViewModel>();
            });
            Mapper = config.CreateMapper();
        }

    }
}

