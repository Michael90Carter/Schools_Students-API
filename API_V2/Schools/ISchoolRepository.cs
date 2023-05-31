using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schools
{
    public interface ISchoolRepository
    {
        IEnumerable<School> GetAllSchools(bool trackChanges);
        /*public  void AnyMethodFromSchoolRepository();*/
    }
}
