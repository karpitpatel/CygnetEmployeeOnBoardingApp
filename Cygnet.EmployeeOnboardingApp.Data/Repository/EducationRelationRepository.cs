using Cygnet.EmployeeOnboardingApp.Core.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Data.Model;
using System.Collections.Generic;
using System.Linq;

namespace Cygnet.EmployeeOnboardingApp.Data.Repository
{
    public interface IEducationRelationRepository : IRepository<EducationRelation>
    {
        EducationRelation GetEducationRelation(int EmpCode);

        // User GetUser(string Email);
        ICollection<EducationRelation> GetEducationRelation();

        //   User UserLogin(string userName, string password);
        // void Isfieldd(User model);
    }

    public class EducationRelationRepository : BaseRepository<EducationRelation>, IEducationRelationRepository
    {
        public EducationRelationRepository(IEmployeeOnBoardingUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        public EducationRelation GetEducationRelation(int EmpCode)
        {
            return Get(_ => _.Id == EmpCode).FirstOrDefault();
        }

        public ICollection<EducationRelation> GetEducationRelation()
        {
            return Get().ToList();
        }
    }
}