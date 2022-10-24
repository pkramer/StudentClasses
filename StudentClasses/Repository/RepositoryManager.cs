using StudentClasses.Contracts;
using StudentClasses.Entities;

namespace StudentClasses.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private ISubjectRepository? _subjectRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public ISubjectRepository Subject
        {
            get
            {
                if (_subjectRepository == null)
                    _subjectRepository = new SubjectRepository(_repositoryContext);

                return _subjectRepository;
            }
        }

        public void Save() => _repositoryContext.SaveChanges();
    }
}