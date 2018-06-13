using Cygnet.EmployeeOnboardingApp.Core.Data.Mapping;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Mapping
{
    public class FamilyRelationMapping : BaseEntityMap<FamilyRelation>
    {
        public FamilyRelationMapping()
        {
            // Table and column mapping
            ToTable("FamilyRelation");

            // Primary key
            HasKey(t => t.Id);
        }
    }
}