using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Cygnet.EmployeeOnboardingApp.Data.Model;
using System.ComponentModel;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewModel
{
    public class PersonalDetailsViewModel : BaseViewModel
    {
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]
        [DisplayName("Father's Name")]
        public string Father_Name { get; set; }
        [Required]
        public string Sex { get; set; }
        [Required]
        [DisplayName("Marital Status")]
        public string Marital_Stat { get; set; }

        [DisplayName("Date Of Anniversary")]
        public string Date_Anniv { get; set; }
        [Required(ErrorMessage = "Dob is mandatory.")]
        [DisplayName("Date Of Birth")]
        //public DateTime Dob { get; set; }

        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Dob { get; set; }
        [Required]
        [DisplayName("Name Of the Company")]
        public string Name_Company { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        [DisplayName("Blood Group")]
        public string Blood_Grp { get; set; }
        public string Allergy { get; set; }
        public string Ailment { get; set; }

     /*   [ForeignKey("User")]
        public string Name { get; set; }
        public virtual User User { get; set; }*/
    }
}
