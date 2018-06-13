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

    public class EducationRelationMapping : BaseMapper<EducationRelationViewModel, EducationRelation>
    {
        public EducationRelationMapping()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // Configure AutoMapper
                cfg.CreateMap<EducationRelationViewModel, EducationRelation>();
                cfg.CreateMap<EducationRelation, EducationRelationViewModel>();
            });
            Mapper = config.CreateMapper();
        }

    }
}

