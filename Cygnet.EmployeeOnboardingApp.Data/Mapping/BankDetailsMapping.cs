using Cygnet.EmployeeOnboardingApp.Core.Data.Mapping;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Mapping
{
    public class BankDetailsMapping : BaseEntityMap<BankDetails>
    {
        public BankDetailsMapping()
        {
            // Table and column mapping
            ToTable("BankDetails");

            HasKey(t => t.Id);

        }
    }
}