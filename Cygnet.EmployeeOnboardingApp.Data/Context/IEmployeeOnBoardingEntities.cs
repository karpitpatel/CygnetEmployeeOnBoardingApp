using Cygnet.EmployeeOnboardingApp.Core.Data.Context;
using Cygnet.EmployeeOnboardingApp.Data.Model;
using System.Data.Entity;

namespace Cygnet.EmployeeOnboardingApp.Data.Context
{
    public interface IEmployeeOnBoardingEntities : IDbContext
    {
        IDbSet<TestUOW> TestUOW { get; set; }
        IDbSet<User> User { get; set; }
        IDbSet<PersonalDetails> PersonalDetails { get; set; }
        IDbSet<ContactDetails> ContactDetails { get; set; }
        IDbSet<AccomodationDetails> AccomodationDetails { get; set; }
        IDbSet<BankDetails> BankDetails { get; set; }
       
        IDbSet<NomineeDetails> NomineeDetails { get; set; }
        IDbSet<OriginDetails> OriginDetails { get; set; }
        IDbSet<VariousCardDetails> VariousCardDetails { get; set; }
        IDbSet<WorkingHistoryDetails> WorkingHistoryDetails { get; set; }
        IDbSet<Declaration> Declaration { get; set; }
        IDbSet<AdditionalDetails> AdditionalDetails { get; set; }
        
        IDbSet<Education> Education{ get; set; }
        IDbSet<Family> Family { get; set; }
    }
}