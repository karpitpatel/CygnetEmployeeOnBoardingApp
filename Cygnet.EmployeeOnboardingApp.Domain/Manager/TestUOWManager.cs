using Cygnet.EmployeeOnboardingApp.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Domain.ViewMapping;
using Cygnet.EmployeeOnboardingApp.Domain.ViewModel;
using System.Collections.Generic;

namespace Cygnet.EmployeeOnboardingApp.Domain.Manager
{
    public interface ITestUOWManager
    {
        List<TestUOWViewModel> GetAllTestUOWs();

        TestUOWViewModel GetTestUOW(int id);
    }

    public class TestUOWManager : BaseManager, ITestUOWManager
    {
        private readonly ITestUOWRepository _testUOWRepository;
        private TestUOWMapping testUOWMapping;

        public TestUOWManager(ITestUOWRepository testUOWRepository)
        {
            _testUOWRepository = testUOWRepository;
            testUOWMapping = new TestUOWMapping();
        }

        public List<TestUOWViewModel> GetAllTestUOWs()
        {
            var dataModelList = _testUOWRepository.GetTestUOWs();
            return testUOWMapping.MapToViewList(dataModelList);
        }

        public TestUOWViewModel GetTestUOW(int id)
        {
            var dataModel = _testUOWRepository.GetTestUOW(id);
            return testUOWMapping.MapToView(dataModel);
        }
    }
}