using Cygnet.EmployeeOnboardingApp.Core.Data.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cygnet.EmployeeOnboardingApp.Data.Model
{
    public class ContactDetails : BaseEntity
    {
        public string Email { get; set; }
        public int HomeNo { get; set; }
        public int MobNo { get; set; }
        public string TempAddr { get; set; }
        public string PermAddr { get; set; }
        public int Pincode_tempaddr { get; set; }
        public int Pincode_permadrr { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}