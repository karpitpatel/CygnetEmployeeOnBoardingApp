using Cygnet.EmployeeOnboardingApp.Core.Data.Mapping;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Mapping
{
    public class EducationRelationMapping : BaseEntityMap<EducationRelation>
    {
        public EducationRelationMapping()
        {
            // Table and column mapping
            ToTable("EducationRelation");

            // Primary key
            HasKey(t => t.Id);
        }
    }
}