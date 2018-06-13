namespace Cygnet.EmployeeOnboardingApp.Domain.ViewModel
{
    public class EducationViewModel : BaseViewModel

    {
        public int Id { get; set; }
        public string School_College { get; set; }
        public string Board_University { get; set; }
        public string Degree { get; set; }
        public int Year_Passing { get; set; }
        public string Grade { get; set; }
        public int UserId { get; set; }
    }
}