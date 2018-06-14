using System.ComponentModel.DataAnnotations;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewModel
{
    public class UserViewModel : BaseViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Email is mandatory.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is mandatory.")]
        public string Password { get; set; }

        public string Name { get; set; }
    }
}