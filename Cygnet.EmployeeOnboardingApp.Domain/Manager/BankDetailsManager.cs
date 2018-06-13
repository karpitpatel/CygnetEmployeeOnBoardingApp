using Cygnet.EmployeeOnboardingApp.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Domain.ViewMapping;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using System.Collections.Generic;

namespace Cygnet.EmployeeOnboardingApp.Domain.Manager
{
    public interface IBankDetailsManager
    {
        List<BankDetailsViewModel> GetAllBankDetails();

        BankDetailsViewModel GetBankDetails(int EmpCode);

        void IsRegister(BankDetailsViewModel bankDetailsViewModel);

        // void GetBankDetails(int? id);
        void IsUpdate(BankDetailsViewModel bankDetailsViewModel);
    }

    public class BankDetailsManager : BaseManager, IBankDetailsManager
    {
        private readonly IBankDetailsRepository _bankDetailsRepository;
        private BankDetailsMapping bankDetailsMapping;

        public BankDetailsManager(IBankDetailsRepository bankDetailsRepository)
        {
            _bankDetailsRepository = bankDetailsRepository;
            bankDetailsMapping = new BankDetailsMapping();
        }

        public List<BankDetailsViewModel> GetAllBankDetails()
        {
            var dataModelList = _bankDetailsRepository.GetBankDetails();
            return bankDetailsMapping.MapToViewList(dataModelList);
        }

        public BankDetailsViewModel GetBankDetails(int EmpCode)
        {
            var dataModel = _bankDetailsRepository.GetBankDetails(EmpCode);
            return bankDetailsMapping.MapToView(dataModel);
        }

        public void IsRegister(BankDetailsViewModel bankDetailsViewModel)
        {
            _bankDetailsRepository.IsRegisterr(bankDetailsMapping.MapToModel(bankDetailsViewModel));
            _bankDetailsRepository.UnitOfWork.Save();
        }

        public void IsUpdate(BankDetailsViewModel bankDetailsViewModel)
        {
            _bankDetailsRepository.IsUpdatee(bankDetailsMapping.MapToModel(bankDetailsViewModel));
            _bankDetailsRepository.UnitOfWork.Save();
        }
    }
}