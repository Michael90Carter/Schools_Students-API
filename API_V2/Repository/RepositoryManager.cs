using Entities;
using Schools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private ISchoolRepository _schoolRepository;
        private ITeacherRepository _teacherRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
        public ISchoolRepository School
        {
            get
            {
                if (_schoolRepository == null)
                    _schoolRepository = new SchoolRepository(_repositoryContext);
                return _schoolRepository;
            }
        }

        public ITeacherRepository Teacher
        {
            get
            {
                if (_teacherRepository == null)
                    _teacherRepository = new TeacherRepository(_repositoryContext);
                return _teacherRepository;
            }
        }
        public void Save() => _repositoryContext.SaveChanges();


    }
}
