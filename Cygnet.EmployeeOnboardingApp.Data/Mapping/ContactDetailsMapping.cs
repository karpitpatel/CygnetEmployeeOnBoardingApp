using Cygnet.EmployeeOnboardingApp.Core.Data.Mapping;
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