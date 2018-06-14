using Cygnet.EmployeeOnboardingApp.Core.Data.Mapping;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Mapping
{
    public class VariousCardDetailsMapping : BaseEntityMap<VariousCardDetails>
    {
        public VariousCardDetailsMapping()
        {
            // Table and column mapping
            ToTable("VariousCaredDetails");

            // Primary key
            HasKey(t => t.Id);
        }
    }
}