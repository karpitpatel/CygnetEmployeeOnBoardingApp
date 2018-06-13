

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

    public class DeclarationMapping : BaseMapper<DeclarationViewModel, Declaration>
    {
        public DeclarationMapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // Configure AutoMapper
                cfg.CreateMap<DeclarationViewModel, Declaration>();
                cfg.CreateMap<Declaration, DeclarationViewModel>();
            });
            Mapper = config.CreateMapper();
        }

    }
}

