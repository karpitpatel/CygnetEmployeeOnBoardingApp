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
    public class ContactDetailsMapping : BaseEntityMap<ContactDetails>
    {
        public ContactDetailsMapping()
        {
            // Table and column mapping
            ToTable("ContactDetails");

            // Primary key
            HasKey(t => t.Id);

        }

    }
}