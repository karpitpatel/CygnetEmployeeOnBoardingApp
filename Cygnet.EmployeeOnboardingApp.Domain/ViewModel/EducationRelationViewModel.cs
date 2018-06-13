using System.ComponentModel.DataAnnotations;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewModel
{
    public class EducationRelationViewModel : BaseViewModel
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        public string Degree { get; set; }
    }
}