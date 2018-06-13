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
    public class BankDetailsMapping : BaseEntityMap<BankDetails>
    {
        public BankDetailsMapping()
        {

            
            // Table and column mapping
            ToTable("BankDetails");

          /*  HasRequired(x => x.EmpCode)      // Your Xyz has an optional Address
           .WithMany()                         // Address may be owned by many Xyz objects
           .HasForeignKey(x => x.EmpCode);*/



        }

    }
}