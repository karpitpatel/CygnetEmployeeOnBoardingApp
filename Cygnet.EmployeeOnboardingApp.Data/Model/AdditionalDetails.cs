using Cygnet.EmployeeOnboardingApp.Core.Data.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cygnet.EmployeeOnboardingApp.Data.Model
{
    public class AdditionalDetails : BaseEntity
    {
    
        public string Rel_With_Present_Emp { get; set; }
        public string Name_Emp { get; set; }
        public string Relationship { get; set; }
        public string Details_If_Worked_Before { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}