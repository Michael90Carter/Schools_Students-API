using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schools
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> GetAllTeachers(bool trackChanges);
        /*public void AnyMethodFromTeacherRepository();*/
    }
}
