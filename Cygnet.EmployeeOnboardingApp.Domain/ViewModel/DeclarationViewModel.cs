using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewModel
{
    public class DeclarationViewModel : BaseViewModel
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [DisplayName("KYC Details")]
        public string Kyc_Details { get; set; }

        [DisplayName("Member of EPF Schema?")]
        public string Is_Mem_Epf_Schema { get; set; }

        [DisplayName("Date of Allotment of Insurance Number")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Dt_Allot_Ins_No { get; set; }

        [DisplayName("Date of Issue of TIC")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Dt_Issue_Tic { get; set; }
    }
}