using StudentClasses.Entities.Models;

namespace StudentClasses.Contracts
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents(bool trackChanges);
    }
}
