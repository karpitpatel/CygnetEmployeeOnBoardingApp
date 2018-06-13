using Cygnet.EmployeeOnboardingApp.Core.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Data.Model;
using System.Collections.Generic;
using System.Linq;

namespace Cygnet.EmployeeOnboardingApp.Data.Repository
{
    public interface ITestUOWRepository : IRepository<TestUOW>
    {
        TestUOW GetTestUOW(int id);

        ICollection<TestUOW> GetTestUOWs();
    }

    public class TestUOWRepository : BaseRepository<TestUOW>, ITestUOWRepository
    {
        public TestUOWRepository(IEmployeeOnBoardingUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        public TestUOW GetTestUOW(int id)
        {
            return Get(_ => _.Id == id).FirstOrDefault();
        }

        public ICollection<TestUOW> GetTestUOWs()
        {
            return Get().ToList();
        }
    }
}