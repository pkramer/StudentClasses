using StudentClasses.Repository;

namespace StudentClasses.Contracts
{
    public interface IRepositoryManager
    {
        ISubjectRepository Subject { get; }
        IStudentRepository Student { get; }
        void Save();
    }
}
