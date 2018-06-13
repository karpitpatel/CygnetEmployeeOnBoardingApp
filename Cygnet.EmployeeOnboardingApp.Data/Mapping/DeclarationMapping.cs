using Cygnet.EmployeeOnboardingApp.Core.Data.Mapping;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Mapping
{
    public class DeclarationMapping : BaseEntityMap<Declaration>
    {
        public DeclarationMapping()
        {
            // Table and column mapping
            ToTable("Declaration");

            // Primary key
            HasKey(t => t.Id);
        }
    }
}