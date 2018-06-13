

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

    public class OriginDetailsMapping : BaseMapper<OriginDetailsViewModel, OriginDetails>
    {
        public OriginDetailsMapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // Configure AutoMapper
                cfg.CreateMap<OriginDetailsViewModel, OriginDetails>();
                cfg.CreateMap<OriginDetails, OriginDetailsViewModel>();
            });
            Mapper = config.CreateMapper();
        }

    }
}

