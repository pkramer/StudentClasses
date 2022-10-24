using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentClasses.Entities.Models
{
    public class Student
    {
        [Column("StudentId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Student name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Age is a required field.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Level is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for the Level is 20 characters.")]
        public string? Level { get; set; }

        [ForeignKey(nameof(Subject))]
        public Guid SubjectId { get; set; }
        public Subject? Company { get; set; }
    }
}
