using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewModel
{
    public class WorkingHistoryDetailsViewModel : BaseViewModel
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [DisplayName("Name Of the Company")]
        public string Name_Company { get; set; }

        [Required]
        [DisplayName("Address Of the Company")]
        public string Addr_Company { get; set; }

        [Required]
        [DisplayName("Designation")]
        public string Designation { get; set; }

        [Required]
        [DisplayName("Department")]
        public string Department { get; set; }

        [Required]
        [DisplayName("Designation")]
        public string Designation_Person_ReportingTo { get; set; }

        [Required]
        [DisplayName("Date Of Joining")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Doj { get; set; }

        [Required]
        [DisplayName("Date Of Leaving")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Dol { get; set; }

        [Required]
        [DisplayName("Monthly Gross Salary")]
        public int Monthly_Gross_Salary { get; set; }

        [Required]
        [DisplayName("Reason For Leaving")]
        public string Reason_For_Leaving { get; set; }

        [Required]
        [DisplayName("Detailed By")]
        public string Detailed_By { get; set; }

        [Required]
        [DisplayName("Pension Number")]
        public string Pension_No { get; set; }

        [Required]
        [DisplayName("Reporting To")]
        public string Reporting_To { get; set; }

        [Required]
        [DisplayName("CTC Per Annum")]
        public string Ctc_Perannum { get; set; }

        [DisplayName("Reference 1 Name")]
        public string Ref1_Name { get; set; }

        [DisplayName("Reference 1 Contact")]
        public string Ref1_Phn { get; set; }

        [DisplayName("Reference 1 Address")]
        public string Ref1_Addr { get; set; }

        [DisplayName("Reference 2 Name")]
        public string Ref2_Name { get; set; }

        [DisplayName("Reference 2 Contact")]
        public string Ref2_Phn { get; set; }

        [DisplayName("Reference 2 Address")]
        public string Ref2_Addr { get; set; }
    }
}