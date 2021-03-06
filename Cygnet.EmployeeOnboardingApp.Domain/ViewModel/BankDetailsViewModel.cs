﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewModel
{
    public class BankDetailsViewModel : BaseViewModel
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [DisplayName("Account Number")]
        public string Acc_No { get; set; }

        [Required]
        [DisplayName("IFSC Code")]
        public string Ifsc_Code { get; set; }

        [Required]
        [DisplayName("PAN Card Number")]
        [RegularExpression(@"[A-Z]{5}\d{4}[A-Z]{1}$", ErrorMessage = "Not a valid pancard number")]
        public string Pan_No { get; set; }

        [DisplayName("UAN Number")]
        public string Uan_No { get; set; }

        [DisplayName("Insuance Number")]
        public string Ins_No { get; set; }

        [DisplayName("Mediclaim Number")]
        public string Mediclaim { get; set; }

        [DisplayName("Life Insurance Number")]
        public string Life_Ins { get; set; }

        [DisplayName("Family Pension Scheme Number")]
        public string Fam_PensionScheme { get; set; }

        [DisplayName("Provident Fund Number")]
        public string Pf_No { get; set; }
    }
}