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

    public class ContactDetailsMapping : BaseMapper<ContactDetailsViewModel, ContactDetails>
    {
        public ContactDetailsMapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // Configure AutoMapper
                cfg.CreateMap<ContactDetailsViewModel, ContactDetails>();
                cfg.CreateMap<ContactDetails, ContactDetailsViewModel>();
            });
            Mapper = config.CreateMapper();
        }

    }
}

