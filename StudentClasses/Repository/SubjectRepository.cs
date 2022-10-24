using StudentClasses.Contracts;
using StudentClasses.Entities.Models;

namespace StudentClasses.Repository
{
    public class SubjectRepository : RepositoryBase<Subject>, ISubjectRepository
    {
        public SubjectRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<Subject> GetAllSubjects(bool trackChanges) =>
           FindAll(trackChanges)
           .OrderBy(c => c.Name)
           .ToList();
    }
}
