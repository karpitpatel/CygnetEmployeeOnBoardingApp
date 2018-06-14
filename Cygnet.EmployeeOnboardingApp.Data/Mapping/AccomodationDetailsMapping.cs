using Cygnet.EmployeeOnboardingApp.Core.Data.Mapping;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Mapping
{
    public class AccomodationDetailsMapping : BaseEntityMap<AccomodationDetails>
    {
        public AccomodationDetailsMapping()
        {
            // Table and column mapping
            ToTable("AccomodationDetails");

            // Primary key
            HasKey(t => t.Id);
        }
    }
}