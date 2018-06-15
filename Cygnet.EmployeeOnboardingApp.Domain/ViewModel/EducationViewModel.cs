using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cygnet.EmployeeOnboardingApp.Domain.ViewModel
{
    public class EducationViewModel : BaseViewModel

    {
        public int Id { get; set; }
        [DisplayName("School/College")]
        public string School_College { get; set; }
        [DisplayName("Board/University")]
        public string Board_University { get; set; }
        public string Degree { get; set; }
        [DisplayName("Year Of Passing")]
        [Range(1800,2018, ErrorMessage = "Value must be between 1800 to 2018")]
        public int Year_Passing { get; set; }
        public string Grade { get; set; }
        public int UserId { get; set; }
    }
}