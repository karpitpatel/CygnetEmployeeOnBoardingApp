using Cygnet.EmployeeOnboardingApp.Core.Data.Context;
using Cygnet.EmployeeOnboardingApp.Data.Mapping;
using Cygnet.EmployeeOnboardingApp.Data.Model;
using System.Data.Entity;

namespace Cygnet.EmployeeOnboardingApp.Data.Context
{
    public class EmployeeOnBoardingEntities : BaseDbContext, IEmployeeOnBoardingEntities
    {
        public EmployeeOnBoardingEntities()
        {
        }

        public EmployeeOnBoardingEntities(string connectionString)
            : base(connectionString)
        {
        }

        public IDbSet<TestUOW> TestUOW { get; set; }
        public IDbSet<User> User { get; set; }
        public IDbSet<PersonalDetails> PersonalDetails { get; set; }
        public IDbSet<ContactDetails> ContactDetails { get; set; }
        public IDbSet<AccomodationDetails> AccomodationDetails { get; set; }
        public IDbSet<BankDetails> BankDetails { get; set; }
        
        public IDbSet<NomineeDetails> NomineeDetails { get; set; }
        public IDbSet<OriginDetails> OriginDetails { get; set; }
        public IDbSet<VariousCardDetails> VariousCardDetails { get; set; }
        public IDbSet<WorkingHistoryDetails> WorkingHistoryDetails { get; set; }
        public IDbSet<Declaration> Declaration { get; set; }
        public IDbSet<AdditionalDetails> AdditionalDetails { get; set; }
     
        public IDbSet<Family> Family { get; set; }
        public IDbSet<Education> Education { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            if (modelBuilder == null) return;

            modelBuilder.Configurations.Add(new TestUOWMapping());
            modelBuilder.Configurations.Add(new AccomodationDetailsMapping());
            modelBuilder.Configurations.Add(new AdditionalDetailsMapping());
            modelBuilder.Configurations.Add(new BankDetailsMapping());
            modelBuilder.Configurations.Add(new ContactDetailsMapping());
            modelBuilder.Configurations.Add(new DeclarationMapping());
            modelBuilder.Configurations.Add(new NomineeDetailsMapping());
            modelBuilder.Configurations.Add(new OriginDetailsMapping());
            modelBuilder.Configurations.Add(new PersonalDetailsMapping());
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new VariousCardDetailsMapping());
            modelBuilder.Configurations.Add(new WorkingHistoryDetailsMapping());
           
            modelBuilder.Configurations.Add(new FamilyMapping());
           
            modelBuilder.Configurations.Add(new EducationMapping());
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

   
    }
}