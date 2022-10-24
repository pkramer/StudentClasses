using StudentClasses.Repository;

namespace StudentClasses.Contracts
{
    public interface IRepositoryManager
    {
        ISubjectRepository Subject { get; }
        void Save();
    }
}
