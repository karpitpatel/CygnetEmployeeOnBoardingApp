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
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Home Contact Number")]
        public string HomeNo { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Mobile Number")]
        public string MobNo { get; set; }

        [Required]
        [DisplayName("Temporary Address")]
        public string TempAddr { get; set; }

        [Required]
        [DisplayName("Pincode")]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip")]
        public string Pincode_tempaddr { get; set; }

        [Required]
        [DisplayName("Pemanent Address")]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip")]
        public string PermAddr { get; set; }

        [Required]
        [DisplayName("Pincode")]
        public string Pincode_permadrr { get; set; }
    }
}