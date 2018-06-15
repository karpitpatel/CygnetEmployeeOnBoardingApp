using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewModel
{
    public class VariousCardDetailsViewModel : BaseViewModel
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [DisplayName("Passport Number")]
        public string Passport_No { get; set; }

        [DisplayName("Validity of Passport")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Passport_Validity { get; set; }
       
        [DisplayName("ESIC Number")]
        public string Esic_No { get; set; }

        [DisplayName("Vehicle Number")]
        public string Vehicle_No { get; set; }

        [DisplayName("Pension Payment Order Number")]
        public string Pension_Payment_OrderNo { get; set; }

        [DisplayName("Scheme Certificate Number")]
        public string Scheme_Certificate_No { get; set; }

        [Required]
      
        [DisplayName("Aadhar Card Number")]
        [StringLength(16, ErrorMessage = "Invalid Aadhar Number", MinimumLength = 16)]
        public string Aadhar_No { get; set; }

        [DisplayName("Election Number")]
        [StringLength(10, ErrorMessage = "Invalid Election Number", MinimumLength = 10)]
        public string Election_No { get; set; }
    }
}