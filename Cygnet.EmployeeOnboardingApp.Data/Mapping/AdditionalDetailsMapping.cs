using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cygnet.EmployeeOnboardingApp.Core.Data.Mapping;
using Cygnet.EmployeeOnboardingApp.Data.Mapping;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Mapping
{
    public class AdditionalDetailsMapping : BaseEntityMap<AdditionalDetails>
    {
        public AdditionalDetailsMapping()
        {
            // Table and column mapping
            ToTable("AdditionalDetails");

            // Primary key
            HasKey(t => t.Id);

        }

    }
}