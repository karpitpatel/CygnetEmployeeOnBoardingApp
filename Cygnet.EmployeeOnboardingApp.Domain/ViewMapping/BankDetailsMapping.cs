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
    public class BankDetailsMapping : BaseMapper<BankDetailsViewModel, BankDetails>
    {
        public BankDetailsMapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // Configure AutoMapper
                cfg.CreateMap<BankDetailsViewModel, BankDetails>();
                cfg.CreateMap<BankDetails, BankDetailsViewModel>();
            });
            Mapper = config.CreateMapper();
        }
    }
}