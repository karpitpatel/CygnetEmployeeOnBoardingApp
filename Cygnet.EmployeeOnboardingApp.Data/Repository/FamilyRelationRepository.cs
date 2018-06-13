using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cygnet.EmployeeOnboardingApp.Core.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Repository
{
    public interface IFamilyRelationRepository : IRepository<FamilyRelation>
    {
        FamilyRelation GetFamilyRelation(int EmpCode);
        // User GetUser(string Email);
        ICollection<FamilyRelation> GetFamilyRelation();
      //   User UserLogin(string userName, string password);
       // void Isfieldd(User model);

    }
    public class FamilyRelationRepository : BaseRepository<FamilyRelation>, IFamilyRelationRepository
    {
        public FamilyRelationRepository(IEmployeeOnBoardingUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
        public FamilyRelation GetFamilyRelation(int EmpCode)
        {
            return Get(_ => _.Id == EmpCode).FirstOrDefault();
        }
        public ICollection<FamilyRelation> GetFamilyRelation()
        {
            return Get().ToList();
        }


          }
}
