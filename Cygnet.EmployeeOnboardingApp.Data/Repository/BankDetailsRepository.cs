using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cygnet.EmployeeOnboardingApp.Core.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Repository
{
    public interface IBankDetailsRepository : IRepository<BankDetails>
    {
        BankDetails GetBankDetails(int EmpCode);
        ICollection<BankDetails> GetBankDetails();
        void IsRegisterr(BankDetails model);
      void  IsUpdatee(BankDetails model);
        
        }
    public class BankDetailsRepository : BaseRepository<BankDetails>, IBankDetailsRepository
    {
        public BankDetailsRepository(IEmployeeOnBoardingUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
        public BankDetails GetBankDetails(int EmpCode)
        {
            return Get(_ => _.UserId == EmpCode).FirstOrDefault();
        }
        public ICollection<BankDetails> GetBankDetails()
        {
            return Get().ToList();
        }
        public void IsRegisterr(BankDetails model)
        {
            Insert(model);
        }
        public void IsUpdatee(BankDetails model)
        {
            Update(model);
        }
    }
}
