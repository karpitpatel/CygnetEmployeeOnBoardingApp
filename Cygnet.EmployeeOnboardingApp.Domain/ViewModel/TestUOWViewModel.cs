using System.ComponentModel.DataAnnotations;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewModel
{
    public class TestUOWViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        [Required(ErrorMessage = "Name is mandatory.")]
        public string Name { get; set; }
    }
}