using System.ComponentModel.DataAnnotations;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewModel
{
    public class NomineeDetailsViewModel : BaseViewModel
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Relationship { get; set; }

        [Required]
        public string Address { get; set; }
    }
}