using Cygnet.EmployeeOnboardingApp.Core.Data.Mapping;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Mapping
{
    public class AdditionalDetailsMapping : BaseEntityMap<AdditionalDetails>
    {
        public AdditionalDetailsMapping()
        {
            // Table and column mapping
            ToTable("AdditionalDetails");

            // Primary key
            HasKey(t => t.Id);
        }
    }
}