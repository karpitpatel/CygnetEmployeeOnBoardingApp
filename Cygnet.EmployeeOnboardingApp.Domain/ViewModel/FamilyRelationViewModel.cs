using System.ComponentModel.DataAnnotations;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewModel
{
    public class FamilyRelationViewModel : BaseViewModel
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        public string Relationship { get; set; }
    }
}