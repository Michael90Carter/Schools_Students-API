using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schools
{
    public interface IRepositoryManager
    {
        ISchoolRepository School { get; }
        ITeacherRepository Teacher { get; }
        void Save();
    }
}
