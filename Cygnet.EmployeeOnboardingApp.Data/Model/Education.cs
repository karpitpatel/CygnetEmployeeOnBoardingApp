using Cygnet.EmployeeOnboardingApp.Core.Data.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cygnet.EmployeeOnboardingApp.Data.Model
{
    public class Education : BaseEntity
    {
        // public int EduId { get; set; }
        public string School_College { get; set; }

        public string Board_University { get; set; }
        public string Degree { get; set; }
        public int Year_Passing { get; set; }
        public string Grade { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        //[ForeignKey("EduId")]
        //public EducationRelation EducationRelation { get; set; }
    }
}