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

    public class FamilyDetailsMapping : BaseMapper<FamilyDetailsViewModel, FamilyDetails>
    {
        public FamilyDetailsMapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // Configure AutoMapper
                cfg.CreateMap<FamilyDetailsViewModel, FamilyDetails>();
                cfg.CreateMap<FamilyDetails, FamilyDetailsViewModel>();
            });
            Mapper = config.CreateMapper();
        }

    }
}

