using Cygnet.EmployeeOnboardingApp.Core.Data.Mapping;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Mapping
{
    public class FamilyMapping : BaseEntityMap<Family>
    {
        public FamilyMapping()
        {
            // Table and column mapping
            ToTable("Family");

            // Primary key
            HasKey(t => t.Id);
        }
    }
}