using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cygnet.EmployeeOnboardingApp.Core.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Repository
{
    public interface IDeclarationRepository : IRepository<Declaration>
    {
        Declaration GetDeclaration(int UserId);
        ICollection<Declaration> GetDeclaration();
        void IsRegisterr(Declaration model);
        void IsUpdatee(Declaration model);
    }
    public class DeclarationRepository : BaseRepository<Declaration>, IDeclarationRepository
    {
        public DeclarationRepository(IEmployeeOnBoardingUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
        public Declaration GetDeclaration(int UserId)
        {
            return Get(_ => _.UserId == UserId).FirstOrDefault();
        }
        public ICollection<Declaration> GetDeclaration()
        {
            return Get().ToList();
        }
        public void IsRegisterr(Declaration model)
        {
            Insert(model);
        }
        public void IsUpdatee(Declaration model)
        {
            Update(model);
        }
    }
}
