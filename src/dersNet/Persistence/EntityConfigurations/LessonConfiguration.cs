using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NArchitecture.Core.Security.Hashing;

namespace Persistence.EntityConfigurations;

public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
{
    public void Configure(EntityTypeBuilder<Lesson> builder)
    {
        builder.ToTable("Lessons").HasKey(l => l.Id);

        builder.Property(l => l.Id).HasColumnName("Id").IsRequired();
        builder.Property(l => l.Title).HasColumnName("Title");
        builder.Property(l => l.ParentId).HasColumnName("ParentId");
        builder.Property(l => l.Depth).HasColumnName("Depth");
        builder.Property(l => l.Order).HasColumnName("Order");
        builder.Property(l => l.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(l => l.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(l => l.DeletedDate).HasColumnName("DeletedDate");
        builder.HasData(_seeds);

        builder.HasQueryFilter(l => !l.DeletedDate.HasValue);

    }
    private IEnumerable<Lesson> _seeds
    {
        get
        {
            List<Lesson> seeds = new List<Lesson>();
            var lessonId1 = Guid.NewGuid();
            Lesson lesson1 =
                new()
                {
                    Id = lessonId1,
                    Title = "Lise",
                    Depth = 0,
                    Order = 1,
                    ParentId = null,
                    CreatedDate = DateTime.Now,
                };
            Lesson lesson2 =
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "12.Sýnýf",
                    Depth = 1,
                    Order = 2,
                    ParentId = lessonId1,
                    CreatedDate = DateTime.Now,

                };
            seeds.Add(lesson1);
            seeds.Add(lesson2);
            return seeds;
        }
    }
}