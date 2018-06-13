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
    public class PersonalDetailsMapping : BaseMapper<PersonalDetailsViewModel, PersonalDetails>
    {
        public PersonalDetailsMapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // Configure AutoMapper
                cfg.CreateMap<PersonalDetailsViewModel, PersonalDetails>();
                cfg.CreateMap<PersonalDetails, PersonalDetailsViewModel>();
            });
            Mapper = config.CreateMapper();
        }

    }
}
