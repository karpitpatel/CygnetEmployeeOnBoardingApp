using Cygnet.EmployeeOnboardingApp.Core.Data.Mapping;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Mapping
{
    public class EducationMapping : BaseEntityMap<Education>
    {
        public EducationMapping()
        {
            // Table and column mapping
            ToTable("Education");

            // Primary key
            HasKey(t => t.Id);
        }
    }
}