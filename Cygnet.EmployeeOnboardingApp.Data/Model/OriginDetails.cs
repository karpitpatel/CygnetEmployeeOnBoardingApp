using Cygnet.EmployeeOnboardingApp.Core.Data.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cygnet.EmployeeOnboardingApp.Data.Model
{
    public class OriginDetails : BaseEntity
    {
        public string Is_International_Worker { get; set; }
        public string Country_Origin { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}