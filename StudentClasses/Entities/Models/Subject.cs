using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentClasses.Entities.Models
{
    public class Subject
    {
        [Column("SubjectId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Subject name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Subject description is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Description is 60 characters.")]
        public string? Description { get; set; }

        public string? City { get; set; }
    }
}
