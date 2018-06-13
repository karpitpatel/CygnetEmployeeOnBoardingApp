

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

    public class VariousCardDetailsMapping : BaseMapper<VariousCardDetailsViewModel, VariousCardDetails>
    {
        public VariousCardDetailsMapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // Configure AutoMapper
                cfg.CreateMap<VariousCardDetailsViewModel, VariousCardDetails>();
                cfg.CreateMap<VariousCardDetails, VariousCardDetailsViewModel>();
            });
            Mapper = config.CreateMapper();
        }

    }
}

