using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cygnet.EmployeeOnboardingApp.Core.Data.Repository;
using Cygnet.EmployeeOnboardingApp.Data.Model;

namespace Cygnet.EmployeeOnboardingApp.Data.Repository
{
    public interface IEducationRepository : IRepository<Education>
    {
        Education GetEducation(int EmpCode);
        ICollection<Education> GetAllEducation(int EmpCode);
        ICollection<Education> GetEducation();
        void IsRegisterr(Education model);
        void IsUpdatee(Education model);

    }
    public class EducationRepository : BaseRepository<Education>, IEducationRepository
    {
        public EducationRepository(IEmployeeOnBoardingUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
        public Education GetEducation(int EmpCode)
        {
            return Get(_ => _.UserId == EmpCode).FirstOrDefault();
        }

        public ICollection<Education> GetAllEducation(int EmpCode)
        {
            return Get(_ => _.UserId == EmpCode).ToList();
        }

        public ICollection<Education> GetEducation()
        {
            return Get().ToList();
        }


        public void IsRegisterr(Education model)
        {
            // if (model.Email != null && model.Password != null)
            //    return Update(model).ToList();
            Insert(model);
        }
        public void IsUpdatee(Education model)
        {
            Update(model);
        }


    }
}
