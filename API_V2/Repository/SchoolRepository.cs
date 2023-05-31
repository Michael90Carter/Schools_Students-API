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
    public class SchoolRepository : RepositoryBase<School>, ISchoolRepository
    {
        public SchoolRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<School> GetAllSchools(bool trackChanges) =>
             FindAll(trackChanges)
             .OrderBy(c => c.Name)
             .ToList();

    }
}
