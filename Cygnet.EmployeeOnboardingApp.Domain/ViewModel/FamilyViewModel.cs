using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewModel
{
    public class FamilyViewModel : BaseViewModel
    {
        public int Id { get; set; }

       
        public string Name { get; set; }

        public string Relation { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Contact { get; set; }
        public string Occupation { get; set; }
        [Required]
        [DisplayName("Date of Birth")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Dob { get; set; }
        [DisplayName("Aadhar Number")]
        [StringLength(16, ErrorMessage = "Invalid Aadhar Number", MinimumLength = 16)]
        public string Aadhar_No { get; set; }
        [DisplayName("Do you reside together? ")]
        public string Residing_tog { get; set; }
        public int UserId { get; set; }
    }
}