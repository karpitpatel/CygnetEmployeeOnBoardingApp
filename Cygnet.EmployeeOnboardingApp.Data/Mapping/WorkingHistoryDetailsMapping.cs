using Cygnet.EmployeeOnboardingApp.Core.Data.Mapping;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Mapping
{
    public class WorkingHistoryDetailsMapping : BaseEntityMap<WorkingHistoryDetails>
    {
        public WorkingHistoryDetailsMapping()
        {
            // Table and column mapping
            ToTable("WorkingHistoryDetails");

            // Primary key
            HasKey(t => t.Id);
        }
    }
}