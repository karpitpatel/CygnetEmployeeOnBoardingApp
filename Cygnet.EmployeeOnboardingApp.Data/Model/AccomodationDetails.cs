using Cygnet.EmployeeOnboardingApp.Core.Data.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cygnet.EmployeeOnboardingApp.Data.Model
{
    public class AccomodationDetails : BaseEntity
    {
        // public int Id { get; set; }

        public string Rent_Ownership { get; set; }
        public string Owner_Name { get; set; }
        public string Owner_Contact { get; set; }
        public string Owner_Addr { get; set; }
        public string Owner_Occupation { get; set; }
        public string Neigh1_Name { get; set; }
        public string Neigh1_Contact { get; set; }
        public string Neigh1_Occupation { get; set; }

        public string Neigh2_Name { get; set; }
        public string Neigh2_Contact { get; set; }
        public string Neigh2_Occupation { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}