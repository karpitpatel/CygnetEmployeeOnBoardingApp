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

    public class EducationDetailsMapping : BaseMapper<EducationDetailsViewModel, EducationDetails>
    {
        public EducationDetailsMapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // Configure AutoMapper
                cfg.CreateMap<EducationDetailsViewModel, EducationDetails>();
                cfg.CreateMap<EducationDetails, EducationDetailsViewModel>();
            });
            Mapper = config.CreateMapper();
        }

    }
}

