using Cygnet.EmployeeOnboardingApp.Core.Data.Mapping;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Mapping
{
    public class PersonalDetailsMapping : BaseEntityMap<PersonalDetails>
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