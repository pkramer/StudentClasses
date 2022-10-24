using StudentClasses.Entities.Models;

namespace StudentClasses.Contracts
{
    public interface ISubjectRepository
    {
        IEnumerable<Subject> GetAllSubjects(bool trackChanges);
    }
}
