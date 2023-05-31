using Entities;
using Entities.Models;
using Schools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TeacherRepository : RepositoryBase<Teacher>, ITeacherRepository
    {
        public TeacherRepository(RepositoryContext repositoryContext)
         : base(repositoryContext)
        {
        }

       /* public void AnyMethodFromTeacherRepository()
        {
            throw new NotImplementedException();
        }*/

        public IEnumerable<Teacher> GetAllTeachers(bool trackChanges) =>
             FindAll(trackChanges)
             .OrderBy(c => c.Name)
             .ToList();
    }
}

