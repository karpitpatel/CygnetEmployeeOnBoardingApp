using Cygnet.EmployeeOnboardingApp.Core.Data.Mapping;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Mapping
{
    public class UserMapping : BaseEntityMap<User>
    {
        public UserMapping()
        {
            // Table and column mapping
            ToTable("User");

            // Primary key
            HasKey(t => t.Id);
        }
    }
}