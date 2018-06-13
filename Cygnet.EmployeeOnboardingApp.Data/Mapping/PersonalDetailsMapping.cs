using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using Cygnet.EmployeeOnboardingApp.Core.Data.Mapping;
using Cygnet.EmployeeOnboardingApp.Data.Mapping;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Mapping
{
   public class PersonalDetailsMapping:BaseEntityMap<PersonalDetails>
    {
        public PersonalDetailsMapping()
        {   
            // Table and column mapping
            ToTable("PersonalDetails");

            // Primary key
            HasKey(t => t.Id);
            //HasForeignKey(t => t.Name);

        }


    }
}
