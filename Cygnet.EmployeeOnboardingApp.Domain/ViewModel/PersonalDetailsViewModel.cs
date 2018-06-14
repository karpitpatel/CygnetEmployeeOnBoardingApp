using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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


        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Dob{ get; set; }



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

    }
}