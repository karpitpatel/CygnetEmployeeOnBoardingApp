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
    public class NomineeDetailsMapping : BaseEntityMap<NomineeDetails>
    {
        public NomineeDetailsMapping()
        {
            // Table and column mapping
            ToTable("NomineeDetails");

            // Primary key
            HasKey(t => t.Id);

        }

    }
}