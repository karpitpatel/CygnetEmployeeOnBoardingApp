using Cygnet.EmployeeOnboardingApp.Core.Data.Mapping;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Mapping
{
    public class TestUOWMapping : BaseEntityMap<TestUOW>
    {
        public TestUOWMapping()
        {
            // Table and column mapping
            ToTable("TestUOW");

            // Primary key
            HasKey(t => t.Id);
        }
    }
}