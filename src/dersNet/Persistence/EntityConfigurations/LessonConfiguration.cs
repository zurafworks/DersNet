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

            var lessonIdLise = Guid.NewGuid();
            Lesson lise = new()
            {
                Id = lessonIdLise,
                Title = "Lise",
                Depth = 0,
                Order = 1,
                ParentId = null,
                CreatedDate = DateTime.Now,
            };
            seeds.Add(lise);

            // 9. Sýnýf
            var grade9Id = Guid.NewGuid();
            Lesson grade9 = new()
            {
                Id = grade9Id,
                Title = "9.Sýnýf",
                Depth = 1,
                Order = 2,
                ParentId = lessonIdLise,
                CreatedDate = DateTime.Now,
            };
            seeds.Add(grade9);

            // 9. Sýnýf - Matematik
            var math9Id = Guid.NewGuid();
            Lesson math9 = new()
            {
                Id = math9Id,
                Title = "Matematik",
                Depth = 2,
                Order = 3,
                ParentId = grade9Id,
                CreatedDate = DateTime.Now,
            };
            seeds.Add(math9);

            seeds.Add(new Lesson
            {
                Id = Guid.NewGuid(),
                Title = "Denklemler",
                Depth = 3,
                Order = 4,
                ParentId = math9Id,
                CreatedDate = DateTime.Now,
            });

            seeds.Add(new Lesson
            {
                Id = Guid.NewGuid(),
                Title = "Geometri Temelleri",
                Depth = 3,
                Order = 5,
                ParentId = math9Id,
                CreatedDate = DateTime.Now,
            });

            // 9. Sýnýf - Fizik
            var physics9Id = Guid.NewGuid();
            Lesson physics9 = new()
            {
                Id = physics9Id,
                Title = "Fizik",
                Depth = 2,
                Order = 6,
                ParentId = grade9Id,
                CreatedDate = DateTime.Now,
            };
            seeds.Add(physics9);

            seeds.Add(new Lesson
            {
                Id = Guid.NewGuid(),
                Title = "Hareket ve Kuvvet",
                Depth = 3,
                Order = 7,
                ParentId = physics9Id,
                CreatedDate = DateTime.Now,
            });

            seeds.Add(new Lesson
            {
                Id = Guid.NewGuid(),
                Title = "Enerji",
                Depth = 3,
                Order = 8,
                ParentId = physics9Id,
                CreatedDate = DateTime.Now,
            });

            // 10. Sýnýf
            var grade10Id = Guid.NewGuid();
            Lesson grade10 = new()
            {
                Id = grade10Id,
                Title = "10.Sýnýf",
                Depth = 1,
                Order = 9,
                ParentId = lessonIdLise,
                CreatedDate = DateTime.Now,
            };
            seeds.Add(grade10);

            // 10. Sýnýf - Kimya
            var chemistry10Id = Guid.NewGuid();
            Lesson chemistry10 = new()
            {
                Id = chemistry10Id,
                Title = "Kimya",
                Depth = 2,
                Order = 10,
                ParentId = grade10Id,
                CreatedDate = DateTime.Now,
            };
            seeds.Add(chemistry10);

            seeds.Add(new Lesson
            {
                Id = Guid.NewGuid(),
                Title = "Atom ve Periyodik Sistem",
                Depth = 3,
                Order = 11,
                ParentId = chemistry10Id,
                CreatedDate = DateTime.Now,
            });

            seeds.Add(new Lesson
            {
                Id = Guid.NewGuid(),
                Title = "Kimyasal Baðlar",
                Depth = 3,
                Order = 12,
                ParentId = chemistry10Id,
                CreatedDate = DateTime.Now,
            });

            // 10. Sýnýf - Biyoloji
            var biology10Id = Guid.NewGuid();
            Lesson biology10 = new()
            {
                Id = biology10Id,
                Title = "Biyoloji",
                Depth = 2,
                Order = 13,
                ParentId = grade10Id,
                CreatedDate = DateTime.Now,
            };
            seeds.Add(biology10);

            seeds.Add(new Lesson
            {
                Id = Guid.NewGuid(),
                Title = "Hücre ve Organelleri",
                Depth = 3,
                Order = 14,
                ParentId = biology10Id,
                CreatedDate = DateTime.Now,
            });

            seeds.Add(new Lesson
            {
                Id = Guid.NewGuid(),
                Title = "DNA ve Genetik Kod",
                Depth = 3,
                Order = 15,
                ParentId = biology10Id,
                CreatedDate = DateTime.Now,
            });

            // 11. Sýnýf
            var grade11Id = Guid.NewGuid();
            Lesson grade11 = new()
            {
                Id = grade11Id,
                Title = "11.Sýnýf",
                Depth = 1,
                Order = 16,
                ParentId = lessonIdLise,
                CreatedDate = DateTime.Now,
            };
            seeds.Add(grade11);

            // 11. Sýnýf - Türkçe
            var turkish11Id = Guid.NewGuid();
            Lesson turkish11 = new()
            {
                Id = turkish11Id,
                Title = "Türkçe",
                Depth = 2,
                Order = 17,
                ParentId = grade11Id,
                CreatedDate = DateTime.Now,
            };
            seeds.Add(turkish11);

            seeds.Add(new Lesson
            {
                Id = Guid.NewGuid(),
                Title = "Dil Bilgisi",
                Depth = 3,
                Order = 18,
                ParentId = turkish11Id,
                CreatedDate = DateTime.Now,
            });

            seeds.Add(new Lesson
            {
                Id = Guid.NewGuid(),
                Title = "Edebiyat Akýmlarý",
                Depth = 3,
                Order = 19,
                ParentId = turkish11Id,
                CreatedDate = DateTime.Now,
            });

            // 11. Sýnýf - Tarih
            var history11Id = Guid.NewGuid();
            Lesson history11 = new()
            {
                Id = history11Id,
                Title = "Tarih",
                Depth = 2,
                Order = 20,
                ParentId = grade11Id,
                CreatedDate = DateTime.Now,
            };
            seeds.Add(history11);

            seeds.Add(new Lesson
            {
                Id = Guid.NewGuid(),
                Title = "Osmanlý Tarihi",
                Depth = 3,
                Order = 21,
                ParentId = history11Id,
                CreatedDate = DateTime.Now,
            });

            seeds.Add(new Lesson
            {
                Id = Guid.NewGuid(),
                Title = "Cumhuriyet Dönemi",
                Depth = 3,
                Order = 22,
                ParentId = history11Id,
                CreatedDate = DateTime.Now,
            });

            // 12. Sýnýf
            var grade12Id = Guid.NewGuid();
            Lesson grade12 = new()
            {
                Id = grade12Id,
                Title = "12.Sýnýf",
                Depth = 1,
                Order = 23,
                ParentId = lessonIdLise,
                CreatedDate = DateTime.Now,
            };
            seeds.Add(grade12);

            // 12. Sýnýf - Coðrafya
            var geography12Id = Guid.NewGuid();
            Lesson geography12 = new()
            {
                Id = geography12Id,
                Title = "Coðrafya",
                Depth = 2,
                Order = 24,
                ParentId = grade12Id,
                CreatedDate = DateTime.Now,
            };
            seeds.Add(geography12);

            seeds.Add(new Lesson
            {
                Id = Guid.NewGuid(),
                Title = "Türkiye'nin Coðrafi Bölgeleri",
                Depth = 3,
                Order = 25,
                ParentId = geography12Id,
                CreatedDate = DateTime.Now,
            });

            seeds.Add(new Lesson
            {
                Id = Guid.NewGuid(),
                Title = "Ýklim Bilgisi",
                Depth = 3,
                Order = 26,
                ParentId = geography12Id,
                CreatedDate = DateTime.Now,
            });

                };
            seeds.Add(lesson1);
            seeds.Add(lesson2);
            return seeds;
        }
    }

}