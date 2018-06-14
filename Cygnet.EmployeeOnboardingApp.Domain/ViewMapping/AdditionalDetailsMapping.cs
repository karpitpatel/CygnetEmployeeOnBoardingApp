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
    public class AdditionalDetailsMapping : BaseMapper<AdditionalDetailsViewModel, AdditionalDetails>
    {
        public AdditionalDetailsMapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // Configure AutoMapper
                cfg.CreateMap<AdditionalDetailsViewModel, AdditionalDetails>();
                cfg.CreateMap<AdditionalDetails, AdditionalDetailsViewModel>();
            });
            Mapper = config.CreateMapper();
        }
    }
}