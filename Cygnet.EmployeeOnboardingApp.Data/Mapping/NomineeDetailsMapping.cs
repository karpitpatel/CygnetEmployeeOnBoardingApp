using Cygnet.EmployeeOnboardingApp.Core.Data.Mapping;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Mapping
{
    public class NomineeDetailsMapping : BaseEntityMap<NomineeDetails>
    {
        public NomineeDetailsMapping()
        {
            // Table and column mapping
            ToTable("NomineeDetails");

            // Primary key
            HasKey(t => t.Id);
        }
    }
}