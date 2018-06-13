using Cygnet.EmployeeOnboardingApp.Core.Data.Mapping;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Mapping
{
    public class FamilyDetailsMapping : BaseEntityMap<FamilyDetails>
    {
        public FamilyDetailsMapping()
        {
            // Table and column mapping
            ToTable("FamilyDetails");

            // Primary key
            HasKey(t => t.Id);
        }
    }
}