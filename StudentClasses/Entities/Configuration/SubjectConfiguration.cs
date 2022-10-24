using StudentClasses.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StudentClasses.Entities.Configuration
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasData
            (
                new Subject
                {
                    Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                    Name = "Swedish Class",
                    Description = "Intermediate Swedish",
                    City = "Stockholm"
                },
                new Subject
                {
                    Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                    Name = "Swedish Conversation",
                    Description = "Advanced Dialog",
                    City = "Göteborg"
                }
            );
        }
    }
}
