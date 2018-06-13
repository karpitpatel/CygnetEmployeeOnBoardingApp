using Cygnet.EmployeeOnboardingApp.Core.Data.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cygnet.EmployeeOnboardingApp.Data.Model
{
    public class Family : BaseEntity
    {
        // public int Id { get; set; }

        // public int FamId { get; set; }
        public string Name { get; set; }

        public string Relation { get; set; }
        public string Contact { get; set; }
        public string Occupation { get; set; }
        public string Dob { get; set; }
        public string Aadhar_No { get; set; }
        public string Residing_tog { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        //  [ForeignKey("FamId")]
    }
}