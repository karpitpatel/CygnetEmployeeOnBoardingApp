using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewModel
{
    public class AccomodationDetailsViewModel : BaseViewModel
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [DisplayName("Rent or Ownership Home?")]
        public string Rent_Ownership { get; set; }

        [DisplayName("If on rent, Owner's Name")]
        public string Owner_Name { get; set; }

        [DisplayName("Owner's Contact Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Owner_Contact { get; set; }

        [DisplayName("Owner's Address")]
        public string Owner_Addr { get; set; }

        [DisplayName("Owner's Occupation")]
        public string Owner_Occupation { get; set; }

        [DisplayName("Neighbour's Name")]
        public string Neigh1_Name { get; set; }

        [DisplayName("Neighbour's Contact")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Neigh1_Contact { get; set; }

        [DisplayName("Neighbour's Occupation")]
        public string Neigh1_Occupation { get; set; }

        [DisplayName("Neighbour's Name")]
        public string Neigh2_Name { get; set; }

        [DisplayName("Neighbour's Contact")]
        public string Neigh2_Contact { get; set; }

        [DisplayName("Neighbour's Occupation")]
        public string Neigh2_Occupation { get; set; }
    }
}