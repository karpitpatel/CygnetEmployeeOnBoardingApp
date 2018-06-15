using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewModel
{
    public class ContactDetailsViewModel : BaseViewModel
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [DisplayName("Personal Email ID")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        
        [DisplayName("Home Contact Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string HomeNo { get; set; }

        [Required]
       
        [DisplayName("Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string MobNo { get; set; }


       
        [DisplayName("Alternate Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string AlternateNo { get; set; }

        [Required]
        [DisplayName("Temporary Address")]
        public string TempAddr { get; set; }

        [Required]
        [DisplayName("Pincode")]
        //[DataType(DataType.PostalCode)]
        [StringLength(6, ErrorMessage = "Invalid Pincode", MinimumLength = 6)]
        public string Pincode_tempaddr { get; set; }

        [Required]
        [DisplayName("Pemanent Address")]
        public string PermAddr { get; set; }

        [Required]
        [DisplayName("Pincode")]
        [StringLength(6, ErrorMessage = "Invalid Pincode", MinimumLength = 6)]
        public string Pincode_permadrr { get; set; }
    }
}