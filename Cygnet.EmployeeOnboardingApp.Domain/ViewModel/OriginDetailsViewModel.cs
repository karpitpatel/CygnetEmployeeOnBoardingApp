using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewModel
{
    public class OriginDetailsViewModel : BaseViewModel
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [DisplayName("Are you International Worker?")]
        public string Is_International_Worker { get; set; }

        [Required]
        [DisplayName("Country of Origin")]
        public string Country_Origin { get; set; }
    }
}