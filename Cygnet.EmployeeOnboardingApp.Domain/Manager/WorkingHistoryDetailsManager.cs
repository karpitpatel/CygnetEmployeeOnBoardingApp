using Cygnet.EmployeeOnboardingApp.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Domain.ViewMapping;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using System.Collections.Generic;

namespace Cygnet.EmployeeOnboardingApp.Domain.Manager
{
    public interface IWorkingHistoryDetailsManager
    {
        List<WorkingHistoryDetailsViewModel> GetAllWorkingHistoryDetails();
        WorkingHistoryDetailsViewModel GetWorkingHistoryDetails(int UserId);

        void IsRegister(WorkingHistoryDetailsViewModel workingHistoryDetailsViewModel);
       
        void IsUpdate(WorkingHistoryDetailsViewModel workingHistoryDetailsViewModel);
    }

    public class WorkingHistoryDetailsManager : BaseManager, IWorkingHistoryDetailsManager
    {
        private readonly IWorkingHistoryDetailsRepository _workingHistoryDetailsRepository;
        private WorkingHistoryDetailsMapping workingHistoryDetailsMapping;

        public WorkingHistoryDetailsManager(IWorkingHistoryDetailsRepository workingHistoryDetailsRepository)
        {
            _workingHistoryDetailsRepository = workingHistoryDetailsRepository;
            workingHistoryDetailsMapping = new WorkingHistoryDetailsMapping();
        }

        public List<WorkingHistoryDetailsViewModel> GetAllWorkingHistoryDetails()
        {
            var dataModelList = _workingHistoryDetailsRepository.GetWorkingHistoryDetails();
            return workingHistoryDetailsMapping.MapToViewList(dataModelList);
        }

        public WorkingHistoryDetailsViewModel GetWorkingHistoryDetails(int UserId)
        {
            var dataModel = _workingHistoryDetailsRepository.GetWorkingHistoryDetails(UserId);
            return workingHistoryDetailsMapping.MapToView(dataModel);
        }

        public void IsRegister(WorkingHistoryDetailsViewModel workingHistoryDetailsViewModel)
        {
            _workingHistoryDetailsRepository.IsRegisterr(workingHistoryDetailsMapping.MapToModel(workingHistoryDetailsViewModel));
            _workingHistoryDetailsRepository.UnitOfWork.Save();
        }

        public void IsUpdate(WorkingHistoryDetailsViewModel workingHistoryDetailsViewModel)
        {
            _workingHistoryDetailsRepository.IsUpdatee(workingHistoryDetailsMapping.MapToModel(workingHistoryDetailsViewModel));
            _workingHistoryDetailsRepository.UnitOfWork.Save();
        }
    }
}