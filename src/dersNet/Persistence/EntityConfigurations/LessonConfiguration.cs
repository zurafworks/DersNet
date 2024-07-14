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
            var lessonId2 = Guid.NewGuid();
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
                    Id = lessonId2,
                    Title = "12.S�n�f",
                    Depth = 1,
                    Order = 1,
                    ParentId = lessonId1,
                    CreatedDate = DateTime.Now,

                };
            Lesson lesson3 =
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "11.S�n�f",
                    Depth = 1,
                    Order = 2,
                    ParentId = lessonId1,
                    CreatedDate = DateTime.Now,

                };
            Lesson lesson4 =
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "10.S�n�f",
                    Depth = 1,
                    Order = 3,
                    ParentId = lessonId1,
                    CreatedDate = DateTime.Now,

                };
            Lesson lesson5 =
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "9.S�n�f",
                    Depth = 1,
                    Order = 3,
                    ParentId = lessonId1,
                    CreatedDate = DateTime.Now,

                };
            Lesson lesson6 =
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "Matematik",
                    Depth = 2,
                    Order = 1,
                    ParentId = lessonId2,
                    CreatedDate = DateTime.Now,

                };
            Lesson lesson7 =
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "Edebiyat",
                    Depth = 2,
                    Order = 2,
                    ParentId = lessonId2,
                    CreatedDate = DateTime.Now,

                };
            Lesson lesson8 =
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "Kimya",
                    Depth = 2,
                    Order = 3,
                    ParentId = lessonId2,
                    CreatedDate = DateTime.Now,

                };
            Lesson lesson9 =
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "Biyoloji",
                    Depth = 2,
                    Order = 4,
                    ParentId = lessonId2,
                    CreatedDate = DateTime.Now,

                };
            Lesson lesson10 =
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "Fizik",
                    Depth = 2,
                    Order = 5,
                    ParentId = lessonId2,
                    CreatedDate = DateTime.Now,

                };
            Lesson lesson11 =
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "�ngilizce",
                    Depth = 2,
                    Order = 6,
                    ParentId = lessonId2,
                    CreatedDate = DateTime.Now,

                };

            seeds.Add(lesson1);
            seeds.Add(lesson2);
            seeds.Add(lesson3);
            seeds.Add(lesson4);
            seeds.Add(lesson5);
            seeds.Add(lesson6);
            seeds.Add(lesson7);
            seeds.Add(lesson8);
            seeds.Add(lesson9);
            seeds.Add(lesson10);
            seeds.Add(lesson11);
            return seeds;
        }
    }
}