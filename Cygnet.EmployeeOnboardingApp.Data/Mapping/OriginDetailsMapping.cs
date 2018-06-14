using Cygnet.EmployeeOnboardingApp.Core.Data.Mapping;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Mapping
{
    public class OriginDetailsMapping : BaseEntityMap<OriginDetails>
    {
        public OriginDetailsMapping()
        {
            // Table and column mapping
            ToTable("OriginDetails");

            // Primary key
            HasKey(t => t.Id);
        }
    }
}