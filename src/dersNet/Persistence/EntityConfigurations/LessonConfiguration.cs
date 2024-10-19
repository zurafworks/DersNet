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
        //builder.HasData(_seeds);

        builder.HasQueryFilter(l => !l.DeletedDate.HasValue);

    }
    //public static Guid liseId = Guid.NewGuid();
    //private IEnumerable<Lesson> _seeds
    //{
    //    get
    //    {
    //        List<Lesson> seeds = new List<Lesson>();

    //        #region �lkokul
    //        var ilkokulId = Guid.NewGuid();
    //        seeds.Add(new Lesson
    //        {
    //            Id = ilkokulId,
    //            Title = "�lkokul",
    //            Depth = 0,
    //            Order = 1,
    //            ParentId = null,
    //            CreatedDate = DateTime.UtcNow,
    //        });
    //            #region Temel ��renim
    //            var temelId = Guid.NewGuid();
    //            seeds.Add(new Lesson
    //            {
    //                Id = temelId,
    //                Title = "Temel ��renim",
    //                Depth = 1,
    //                Order = 1,
    //                ParentId = ilkokulId,
    //                CreatedDate = DateTime.UtcNow,
    //            });
    //                #region 1. S�n�f
    //                var sinif1Id = Guid.NewGuid();
    //                seeds.Add(new Lesson
    //                {
    //                    Id = sinif1Id,
    //                    Title = "1. S�n�f",
    //                    Depth = 2,
    //                    Order = 1,
    //                    ParentId = temelId,
    //                    CreatedDate = DateTime.UtcNow,
    //                });
                        
    //                    #region T�rk�e
    //                    var sinif1turkceId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif1turkceId,
    //                        Title = "T�rk�e",
    //                        Depth = 3,
    //                        Order = 1,
    //                        ParentId = sinif1Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Matematik
    //                    var sinif1matId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif1matId,
    //                        Title = "Matematik",
    //                        Depth = 3,
    //                        Order = 2,
    //                        ParentId = sinif1Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Hayat Bilgisi
    //                    var sinif1hbId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif1hbId,
    //                        Title = "Hayat Bilgisi",
    //                        Depth = 3,
    //                        Order = 3,
    //                        ParentId = sinif1Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion
    //        #endregion

    //                #region 2. S�n�f
    //                var sinif2Id = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif2Id,
    //                        Title = "2. S�n�f",
    //                        Depth = 2,
    //                        Order = 2,
    //                        ParentId = temelId,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });

    //                    #region T�rk�e
    //                    var sinif2turkceId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif2turkceId,
    //                        Title = "T�rk�e",
    //                        Depth = 3,
    //                        Order = 1,
    //                        ParentId = sinif2Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Matematik
    //                    var sinif2matId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif2matId,
    //                        Title = "Matematik",
    //                        Depth = 3,
    //                        Order = 2,
    //                        ParentId = sinif2Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Hayat Bilgisi
    //                    var sinif2hbId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif2hbId,
    //                        Title = "Hayat Bilgisi",
    //                        Depth = 3,
    //                        Order = 3,
    //                        ParentId = sinif2Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Yabanc� Dil
    //                    var sinif2ydId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif2ydId,
    //                        Title = "Yabanc� Dil",
    //                        Depth = 3,
    //                        Order = 4,
    //                        ParentId = sinif2Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                #endregion
    //            #endregion

    //            #region �leri ��renim
    //            var ileriId = Guid.NewGuid();
    //            seeds.Add(new Lesson
    //            {
    //                Id = ileriId,
    //                Title = "�leri ��renim",
    //                Depth = 1,
    //                Order = 2,
    //                ParentId = ilkokulId,
    //                CreatedDate = DateTime.UtcNow,
    //            });

    //                #region 3. S�n�f
    //                var sinif3Id = Guid.NewGuid();
    //                seeds.Add(new Lesson
    //                {
    //                    Id = sinif3Id,
    //                    Title = "3. S�n�f",
    //                    Depth = 2,
    //                    Order = 1,
    //                    ParentId = ileriId,
    //                    CreatedDate = DateTime.UtcNow,
    //                });

            
    //                    #region T�rk�e
    //                    var sinif3turkceId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif3turkceId,
    //                        Title = "T�rk�e",
    //                        Depth = 3,
    //                        Order = 1,
    //                        ParentId = sinif3Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Matematik
    //                    var sinif3matId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif3matId,
    //                        Title = "Matematik",
    //                        Depth = 3,
    //                        Order = 2,
    //                        ParentId = sinif3Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Hayat Bilgisi
    //                    var sinif3hbId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif3hbId,
    //                        Title = "Hayat Bilgisi",
    //                        Depth = 3,
    //                        Order = 3,
    //                        ParentId = sinif3Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Fen Bilimleri
    //                    var sinif3fenId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif3fenId,
    //                        Title = "Fen Bilimleri",
    //                        Depth = 3,
    //                        Order = 4,
    //                        ParentId = sinif3Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Yabanc� Dil
    //                    var sinif3ydId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif3ydId,
    //                        Title = "Yabanc� Dil",
    //                        Depth = 3,
    //                        Order = 5,
    //                        ParentId = sinif3Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion


    //                #endregion

    //                #region 4. S�n�f
    //                var sinif4Id = Guid.NewGuid();
    //                seeds.Add(new Lesson
    //                {
    //                    Id = sinif4Id,
    //                    Title = "4. S�n�f",
    //                    Depth = 2,
    //                    Order = 2,
    //                    ParentId = ileriId,
    //                    CreatedDate = DateTime.UtcNow,
    //                });

            
    //                    #region T�rk�e
    //                    var sinif4turkceId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif4turkceId,
    //                        Title = "T�rk�e",
    //                        Depth = 3,
    //                        Order = 1,
    //                        ParentId = sinif4Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Matematik
    //                    var sinif4matId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif4matId,
    //                        Title = "Matematik",
    //                        Depth = 3,
    //                        Order = 2,
    //                        ParentId = sinif4Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Sosyal Bilgiler
    //                    var sinif4hbId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif4hbId,
    //                        Title = "Sosyal Bilgiler",
    //                        Depth = 3,
    //                        Order = 3,
    //                        ParentId = sinif4Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Fen Bilimleri
    //                    var sinif4fenId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif4fenId,
    //                        Title = "Fen Bilimleri",
    //                        Depth = 3,
    //                        Order = 4,
    //                        ParentId = sinif4Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Yabanc� Dil
    //                    var sinif4ydId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif4ydId,
    //                        Title = "Yabanc� Dil",
    //                        Depth = 3,
    //                        Order = 5,
    //                        ParentId = sinif4Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Din K�lt�r�
    //                    var sinif4dinId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif4dinId,
    //                        Title = "Din K�lt�r� ve Ahlak Bilgisi",
    //                        Depth = 3,
    //                        Order = 6,
    //                        ParentId = sinif4Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion




    //                #endregion
    //        #endregion

    //        #endregion

    //        #region Ortaokul
    //        var ortaokulId = Guid.NewGuid();
    //        seeds.Add(new Lesson
    //        {
    //            Id = ortaokulId,
    //            Title = "Ortaokul",
    //            Depth = 0,
    //            Order = 2,
    //            ParentId = null,
    //            CreatedDate = DateTime.UtcNow,
    //        });

    //            #region LGS
    //            var lgsId = Guid.NewGuid();
    //            seeds.Add(new Lesson
    //            {
    //                Id = lgsId,
    //                Title = "LGS",
    //                Depth = 1,
    //                Order = 1,
    //                ParentId = ortaokulId,
    //                CreatedDate = DateTime.UtcNow,
    //            });
    //                #region 5. S�n�f
    //                var sinif5Id = Guid.NewGuid();
    //                seeds.Add(new Lesson
    //                {
    //                    Id = sinif5Id,
    //                    Title = "5. S�n�f",
    //                    Depth = 2,
    //                    Order = 1,
    //                    ParentId = lgsId,
    //                    CreatedDate = DateTime.UtcNow,
    //                });

                                
    //                    #region T�rk�e
    //                    var sinif5turkceId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif5turkceId,
    //                        Title = "T�rk�e",
    //                        Depth = 3,
    //                        Order = 1,
    //                        ParentId = sinif5Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Matematik
    //                    var sinif5matId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif5matId,
    //                        Title = "Matematik",
    //                        Depth = 3,
    //                        Order = 2,
    //                        ParentId = sinif5Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Sosyal Bilgiler
    //                    var sinif5hbId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif5hbId,
    //                        Title = "Sosyal Bilgiler",
    //                        Depth = 3,
    //                        Order = 3,
    //                        ParentId = sinif5Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Fen Bilimleri
    //                    var sinif5fenId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif5fenId,
    //                        Title = "Fen Bilimleri",
    //                        Depth = 3,
    //                        Order = 4,
    //                        ParentId = sinif5Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Yabanc� Dil
    //                    var sinif5ydId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif5ydId,
    //                        Title = "Yabanc� Dil",
    //                        Depth = 3,
    //                        Order = 5,
    //                        ParentId = sinif5Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Din K�lt�r�
    //                    var sinif5dinId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif5dinId,
    //                        Title = "Din K�lt�r� ve Ahlak Bilgisi",
    //                        Depth = 3,
    //                        Order = 6,
    //                        ParentId = sinif5Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion


    //                #endregion

    //                #region 6. S�n�f
    //                var sinif6Id = Guid.NewGuid();
    //                seeds.Add(new Lesson
    //                {
    //                    Id = sinif6Id,
    //                    Title = "6. S�n�f",
    //                    Depth = 2,
    //                    Order = 2,
    //                    ParentId = lgsId,
    //                    CreatedDate = DateTime.UtcNow,
    //                });

                                            
    //                    #region T�rk�e
    //                    var sinif6turkceId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif6turkceId,
    //                        Title = "T�rk�e",
    //                        Depth = 3,
    //                        Order = 1,
    //                        ParentId = sinif6Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Matematik
    //                    var sinif6matId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif6matId,
    //                        Title = "Matematik",
    //                        Depth = 3,
    //                        Order = 2,
    //                        ParentId = sinif6Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Sosyal Bilgiler
    //                    var sinif6hbId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif6hbId,
    //                        Title = "Sosyal Bilgiler",
    //                        Depth = 3,
    //                        Order = 3,
    //                        ParentId = sinif6Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Fen Bilimleri
    //                    var sinif6fenId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif6fenId,
    //                        Title = "Fen Bilimleri",
    //                        Depth = 3,
    //                        Order = 4,
    //                        ParentId = sinif6Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Yabanc� Dil
    //                    var sinif6ydId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif6ydId,
    //                        Title = "Yabanc� Dil",
    //                        Depth = 3,
    //                        Order = 5,
    //                        ParentId = sinif6Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Din K�lt�r�
    //                    var sinif6dinId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif6dinId,
    //                        Title = "Din K�lt�r� ve Ahlak Bilgisi",
    //                        Depth = 3,
    //                        Order = 6,
    //                        ParentId = sinif6Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion


    //                #endregion

    //                #region 7. S�n�f
    //                var sinif7Id = Guid.NewGuid();
    //                seeds.Add(new Lesson
    //                {
    //                    Id = sinif7Id,
    //                    Title = "7. S�n�f",
    //                    Depth = 2,
    //                    Order = 3,
    //                    ParentId = lgsId,
    //                    CreatedDate = DateTime.UtcNow,
    //                });

                                            
    //                    #region T�rk�e
    //                    var sinif7turkceId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif7turkceId,
    //                        Title = "T�rk�e",
    //                        Depth = 3,
    //                        Order = 1,
    //                        ParentId = sinif7Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Matematik
    //                    var sinif7matId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif7matId,
    //                        Title = "Matematik",
    //                        Depth = 3,
    //                        Order = 2,
    //                        ParentId = sinif7Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Sosyal Bilgiler
    //                    var sinif7hbId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif7hbId,
    //                        Title = "Sosyal Bilgiler",
    //                        Depth = 3,
    //                        Order = 3,
    //                        ParentId = sinif7Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Fen Bilimleri
    //                    var sinif7fenId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif7fenId,
    //                        Title = "Fen Bilimleri",
    //                        Depth = 3,
    //                        Order = 4,
    //                        ParentId = sinif7Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Yabanc� Dil
    //                    var sinif7ydId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif7ydId,
    //                        Title = "Yabanc� Dil",
    //                        Depth = 3,
    //                        Order = 5,
    //                        ParentId = sinif7Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Din K�lt�r�
    //                    var sinif7dinId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif7dinId,
    //                        Title = "Din K�lt�r� ve Ahlak Bilgisi",
    //                        Depth = 3,
    //                        Order = 6,
    //                        ParentId = sinif7Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion


    //                #endregion

    //                #region 8. S�n�f
    //                var sinif8Id = Guid.NewGuid();
    //                seeds.Add(new Lesson
    //                {
    //                    Id = sinif8Id,
    //                    Title = "8. S�n�f",
    //                    Depth = 2,
    //                    Order = 4,
    //                    ParentId = lgsId,
    //                    CreatedDate = DateTime.UtcNow,
    //                });

                                            
    //                    #region T�rk�e
    //                    var sinif8turkceId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif8turkceId,
    //                        Title = "T�rk�e",
    //                        Depth = 3,
    //                        Order = 1,
    //                        ParentId = sinif8Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Matematik
    //                    var sinif8matId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif8matId,
    //                        Title = "Matematik",
    //                        Depth = 3,
    //                        Order = 2,
    //                        ParentId = sinif8Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region  T.C. �nk�l�p Tarihi ve Atat�rk��l�k
    //                    var sinif8hbId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif8hbId,
    //                        Title = "T.C. �nk�l�p Tarihi ve Atat�rk��l�k",
    //                        Depth = 3,
    //                        Order = 3,
    //                        ParentId = sinif8Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Fen Bilimleri
    //                    var sinif8fenId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif8fenId,
    //                        Title = "Fen Bilimleri",
    //                        Depth = 3,
    //                        Order = 4,
    //                        ParentId = sinif8Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Yabanc� Dil
    //                    var sinif8ydId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif8ydId,
    //                        Title = "Yabanc� Dil",
    //                        Depth = 3,
    //                        Order = 5,
    //                        ParentId = sinif8Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Din K�lt�r�
    //                    var sinif8dinId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif8dinId,
    //                        Title = "Din K�lt�r� ve Ahlak Bilgisi",
    //                        Depth = 3,
    //                        Order = 6,
    //                        ParentId = sinif8Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion


    //                #endregion
    //            #endregion

    //        #endregion

    //        #region Lise
    //        //var liseId = Guid.NewGuid();
    //        seeds.Add(new Lesson
    //        {
    //            Id = liseId,
    //            Title = "Lise",
    //            Depth = 0,
    //            Order = 3,
    //            ParentId = null,
    //            CreatedDate = DateTime.UtcNow,
    //        });

    //            #region TYT
    //            var tytId = Guid.NewGuid();
    //            seeds.Add(new Lesson
    //            {
    //                Id = tytId,
    //                Title = "TYT",
    //                Depth = 1,
    //                Order = 1,
    //                ParentId = liseId,
    //                CreatedDate = DateTime.UtcNow,
    //            });
    //                #region 9. S�n�f
    //                var sinif9Id = Guid.NewGuid();
    //                seeds.Add(new Lesson
    //                {
    //                    Id = sinif9Id,
    //                    Title = "9. S�n�f",
    //                    Depth = 2,
    //                    Order = 1,
    //                    ParentId = tytId,
    //                    CreatedDate = DateTime.UtcNow,
    //                });

            
                        
                                                        
    //                    #region T�rk Dili ve Edebiyat�
    //                    var sinif9turkceId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif9turkceId,
    //                        Title = "T�rk Dili ve Edebiyat�",
    //                        Depth = 3,
    //                        Order = 1,
    //                        ParentId = sinif9Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Matematik
    //                    var sinif9matId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif9matId,
    //                        Title = "Matematik",
    //                        Depth = 3,
    //                        Order = 2,
    //                        ParentId = sinif9Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region  Tarih
    //                    var sinif9tarId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif9tarId,
    //                        Title = "Tarih",
    //                        Depth = 3,
    //                        Order = 3,
    //                        ParentId = sinif9Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Co�rafya
    //                    var sinif9cogId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif9cogId,
    //                        Title = "Co�rafya",
    //                        Depth = 3,
    //                        Order = 4,
    //                        ParentId = sinif9Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Yabanc� Dil
    //                    var sinif9ydId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif9ydId,
    //                        Title = "Yabanc� Dil",
    //                        Depth = 3,
    //                        Order = 5,
    //                        ParentId = sinif9Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });

    //                        #region Almanca
    //                        var sinif9almId = Guid.NewGuid();
    //                        seeds.Add(new Lesson
    //                        {
    //                            Id = sinif9almId,
    //                            Title = "Almanca",
    //                            Depth = 4,
    //                            Order = 1,
    //                            ParentId = sinif9ydId,
    //                            CreatedDate = DateTime.UtcNow,
    //                        });
    //                        #endregion

    //                        #region �ngilizce
    //                        var sinif9ingId = Guid.NewGuid();
    //                        seeds.Add(new Lesson
    //                        {
    //                            Id = sinif9ingId,
    //                            Title = "�ngilizce",
    //                            Depth = 4,
    //                            Order = 2,
    //                            ParentId = sinif9ydId,
    //                            CreatedDate = DateTime.UtcNow,
    //                        });
    //                        #endregion

    //                    #endregion

    //                    #region Din K�lt�r�
    //                    var sinif9dinId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif9dinId,
    //                        Title = "Din K�lt�r� ve Ahlak Bilgisi",
    //                        Depth = 3,
    //                        Order = 6,
    //                        ParentId = sinif9Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Fizik
    //                    var sinif9fizikId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif9fizikId,
    //                        Title = "Fizik",
    //                        Depth = 3,
    //                        Order = 7,
    //                        ParentId = sinif9Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Kimya
    //                    var sinif9kimyaId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif9kimyaId,
    //                        Title = "Kimya",
    //                        Depth = 3,
    //                        Order = 8,
    //                        ParentId = sinif9Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Biyoloji
    //                    var sinif9bioId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif9bioId,
    //                        Title = "Biyoloji",
    //                        Depth = 3,
    //                        Order = 9,
    //                        ParentId = sinif9Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion




    //                #endregion

    //                #region 10. S�n�f
    //                var sinif10Id = Guid.NewGuid();
    //                seeds.Add(new Lesson
    //                {
    //                    Id = sinif10Id,
    //                    Title = "10. S�n�f",
    //                    Depth = 2,
    //                    Order = 2,
    //                    ParentId = tytId,
    //                    CreatedDate = DateTime.UtcNow,
    //                });

               
                                                        
    //                    #region T�rk Dili ve Edebiyat�
    //                    var sinif10turkceId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif10turkceId,
    //                        Title = "T�rk Dili ve Edebiyat�",
    //                        Depth = 3,
    //                        Order = 1,
    //                        ParentId = sinif10Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Matematik
    //                    var sinif10matId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif10matId,
    //                        Title = "Matematik",
    //                        Depth = 3,
    //                        Order = 2,
    //                        ParentId = sinif10Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region  Tarih
    //                    var sinif10tarId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif10tarId,
    //                        Title = "Tarih",
    //                        Depth = 3,
    //                        Order = 3,
    //                        ParentId = sinif10Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Co�rafya
    //                    var sinif10cogId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif10cogId,
    //                        Title = "Co�rafya",
    //                        Depth = 3,
    //                        Order = 4,
    //                        ParentId = sinif10Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Yabanc� Dil
    //                    var sinif10ydId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif10ydId,
    //                        Title = "Yabanc� Dil",
    //                        Depth = 3,
    //                        Order = 5,
    //                        ParentId = sinif10Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });

    //                        #region Almanca
    //                        var sinif10almId = Guid.NewGuid();
    //                        seeds.Add(new Lesson
    //                        {
    //                            Id = sinif10almId,
    //                            Title = "Almanca",
    //                            Depth = 4,
    //                            Order = 1,
    //                            ParentId = sinif10ydId,
    //                            CreatedDate = DateTime.UtcNow,
    //                        });
    //                        #endregion

    //                        #region �ngilizce
    //                        var sinif10ingId = Guid.NewGuid();
    //                        seeds.Add(new Lesson
    //                        {
    //                            Id = sinif10ingId,
    //                            Title = "�ngilizce",
    //                            Depth = 4,
    //                            Order = 2,
    //                            ParentId = sinif10ydId,
    //                            CreatedDate = DateTime.UtcNow,
    //                        });
    //                        #endregion

    //                    #endregion

    //                    #region Din K�lt�r�
    //                    var sinif10dinId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif10dinId,
    //                        Title = "Din K�lt�r� ve Ahlak Bilgisi",
    //                        Depth = 3,
    //                        Order = 6,
    //                        ParentId = sinif10Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Fizik
    //                    var sinif10fizikId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif10fizikId,
    //                        Title = "Fizik",
    //                        Depth = 3,
    //                        Order = 7,
    //                        ParentId = sinif10Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Kimya
    //                    var sinif10kimyaId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif10kimyaId,
    //                        Title = "Kimya",
    //                        Depth = 3,
    //                        Order = 8,
    //                        ParentId = sinif10Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion

    //                    #region Biyoloji
    //                    var sinif10bioId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif10bioId,
    //                        Title = "Biyoloji",
    //                        Depth = 3,
    //                        Order = 9,
    //                        ParentId = sinif10Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });
    //                    #endregion





    //                #endregion
    //        #endregion


    //            #region AYT
    //            var aytId = Guid.NewGuid();
    //            seeds.Add(new Lesson
    //            {
    //                Id = aytId,
    //                Title = "AYT",
    //                Depth = 1,
    //                Order = 2,
    //                ParentId = liseId,
    //                CreatedDate = DateTime.UtcNow,
    //            });
    //                #region 11. S�n�f
    //                var sinif11Id = Guid.NewGuid();
    //                seeds.Add(new Lesson
    //                {
    //                    Id = sinif11Id,
    //                    Title = "11. S�n�f",
    //                    Depth = 2,
    //                    Order = 1,
    //                    ParentId = aytId,
    //                    CreatedDate = DateTime.UtcNow,
    //                });

    //                    #region Say�sal
    //                    var sinif11sayisalId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif11sayisalId,
    //                        Title = "Say�sal",
    //                        Depth = 3,
    //                        Order = 1,
    //                        ParentId = sinif11Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });

    //                        #region Matematik
    //                        var sinif11matematikId = Guid.NewGuid();
    //                        seeds.Add(new Lesson
    //                        {
    //                            Id = sinif11matematikId,
    //                            Title = "Matematik",
    //                            Depth = 4,
    //                            Order = 1,
    //                            ParentId = sinif11sayisalId,
    //                            CreatedDate = DateTime.UtcNow,
    //                        });
    //                        #endregion

    //                        #region Fizik
    //                        var sinif11fizikId = Guid.NewGuid();
    //                        seeds.Add(new Lesson
    //                        {
    //                            Id = sinif11fizikId,
    //                            Title = "Fizik",
    //                            Depth = 4,
    //                            Order = 2,
    //                            ParentId = sinif11sayisalId,
    //                            CreatedDate = DateTime.UtcNow,
    //                        });
    //                        #endregion

    //                        #region Biyoloji
    //                        var sinif11biyolojiId = Guid.NewGuid();
    //                        seeds.Add(new Lesson
    //                        {
    //                            Id = sinif11biyolojiId,
    //                            Title = "Biyoloji",
    //                            Depth = 4,
    //                            Order = 3,
    //                            ParentId = sinif11sayisalId,
    //                            CreatedDate = DateTime.UtcNow,
    //                        });
    //                        #endregion

    //                        #region Kimya
    //                        var sinif11kimyaId = Guid.NewGuid();
    //                        seeds.Add(new Lesson
    //                        {
    //                            Id = sinif11kimyaId,
    //                            Title = "Kimya",
    //                            Depth = 4,
    //                            Order = 4,
    //                            ParentId = sinif11sayisalId,
    //                            CreatedDate = DateTime.UtcNow,
    //                        });
    //                        #endregion

    //                        #region Geometri
    //                        var sinif11geometriId = Guid.NewGuid();
    //                        seeds.Add(new Lesson
    //                        {
    //                            Id = sinif11geometriId,
    //                            Title = "Geometri",
    //                            Depth = 4,
    //                            Order = 5,
    //                            ParentId = sinif11sayisalId,
    //                            CreatedDate = DateTime.UtcNow,
    //                        });
    //                        #endregion


    //        #endregion

    //                    #region  S�zel
    //                    var sinif11sozelId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif11sozelId,
    //                        Title = "S�zel",
    //                        Depth = 3,
    //                        Order = 3,
    //                        ParentId = sinif11Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });

    //                        #region T�rk Dili Ve Edebiyat�
    //                        var sinif11edebiyatId = Guid.NewGuid();
    //                        seeds.Add(new Lesson
    //                        {
    //                            Id = sinif11edebiyatId,
    //                            Title = "T�rk Dili Ve Edebiyat�",
    //                            Depth = 4,
    //                            Order = 1,
    //                            ParentId = sinif11sozelId,
    //                            CreatedDate = DateTime.UtcNow,
    //                        });
    //                        #endregion

    //                        #region Tarih
    //                        var sinif11tarihId = Guid.NewGuid();
    //                        seeds.Add(new Lesson
    //                        {
    //                            Id = sinif11tarihId,
    //                            Title = "Tarih",
    //                            Depth = 4,
    //                            Order = 2,
    //                            ParentId = sinif11sozelId,
    //                            CreatedDate = DateTime.UtcNow,
    //                        });
    //                        #endregion

    //                        #region Co�rafya
    //                        var sinif11cografyaId = Guid.NewGuid();
    //                        seeds.Add(new Lesson
    //                        {
    //                            Id = sinif11cografyaId,
    //                            Title = "Co�rafya",
    //                            Depth = 4,
    //                            Order = 3,
    //                            ParentId = sinif11sozelId,
    //                            CreatedDate = DateTime.UtcNow,
    //                        });
    //                        #endregion

    //                        #region Felsefe
    //                        var sinif11felsefeId = Guid.NewGuid();
    //                        seeds.Add(new Lesson
    //                        {
    //                            Id = sinif11felsefeId,
    //                            Title = "Felsefe",
    //                            Depth = 4,
    //                            Order = 4,
    //                            ParentId = sinif11sozelId,
    //                            CreatedDate = DateTime.UtcNow,
    //                        });
    //                        #endregion

    //                        #region Din K�lt�r� Ve Ahlak Bilgisi
    //                        var sinif11dinId = Guid.NewGuid();
    //                        seeds.Add(new Lesson
    //                        {
    //                            Id = sinif11dinId,
    //                            Title = "Din K�lt�r� Ve Ahlak Bilgisi",
    //                            Depth = 4,
    //                            Order = 5,
    //                            ParentId = sinif11sozelId,
    //                            CreatedDate = DateTime.UtcNow,
    //                        });
    //        #endregion


    //        #endregion


    //                #endregion


    //                #region 12. S�n�f
    //                var sinif12Id = Guid.NewGuid();
    //                seeds.Add(new Lesson
    //                {
    //                    Id = sinif12Id,
    //                    Title = "12. S�n�f",
    //                    Depth = 2,
    //                    Order = 2,
    //                    ParentId = aytId,
    //                    CreatedDate = DateTime.UtcNow,
    //                });

    //                    #region Say�sal
    //                    var sinif12sayisalId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif12sayisalId,
    //                        Title = "Say�sal",
    //                        Depth = 3,
    //                        Order = 1,
    //                        ParentId = sinif12Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });

    //                        #region Matematik
    //                        var sinif12matematikId = Guid.NewGuid();
    //                        seeds.Add(new Lesson
    //                        {
    //                            Id = sinif12matematikId,
    //                            Title = "Matematik",
    //                            Depth = 4,
    //                            Order = 1,
    //                            ParentId = sinif12sayisalId,
    //                            CreatedDate = DateTime.UtcNow,
    //                        });
    //                        #endregion

    //                        #region Fizik
    //                        var sinif12fizikId = Guid.NewGuid();
    //                        seeds.Add(new Lesson
    //                        {
    //                            Id = sinif12fizikId,
    //                            Title = "Fizik",
    //                            Depth = 4,
    //                            Order = 2,
    //                            ParentId = sinif12sayisalId,
    //                            CreatedDate = DateTime.UtcNow,
    //                        });
    //                        #endregion

    //                        #region Biyoloji
    //                        var sinif12biyolojiId = Guid.NewGuid();
    //                        seeds.Add(new Lesson
    //                        {
    //                            Id = sinif12biyolojiId,
    //                            Title = "Biyoloji",
    //                            Depth = 4,
    //                            Order = 3,
    //                            ParentId = sinif12sayisalId,
    //                            CreatedDate = DateTime.UtcNow,
    //                        });
    //                        #endregion

    //                        #region Kimya
    //                        var sinif12kimyaId = Guid.NewGuid();
    //                        seeds.Add(new Lesson
    //                        {
    //                            Id = sinif12kimyaId,
    //                            Title = "Kimya",
    //                            Depth = 4,
    //                            Order = 4,
    //                            ParentId = sinif12sayisalId,
    //                            CreatedDate = DateTime.UtcNow,
    //                        });
    //                        #endregion

    //                        #region Geometri
    //                        var sinif12geometriId = Guid.NewGuid();
    //                        seeds.Add(new Lesson
    //                        {
    //                            Id = sinif12geometriId,
    //                            Title = "Geometri",
    //                            Depth = 4,
    //                            Order = 5,
    //                            ParentId = sinif12sayisalId,
    //                            CreatedDate = DateTime.UtcNow,
    //                        });
    //                        #endregion


    //                    #endregion

    //                    #region  S�zel
    //                    var sinif12sozelId = Guid.NewGuid();
    //                    seeds.Add(new Lesson
    //                    {
    //                        Id = sinif12sozelId,
    //                        Title = "S�zel",
    //                        Depth = 3,
    //                        Order = 3,
    //                        ParentId = sinif12Id,
    //                        CreatedDate = DateTime.UtcNow,
    //                    });

    //                        #region T�rk Dili Ve Edebiyat�
    //                        var sinif12edebiyatId = Guid.NewGuid();
    //                        seeds.Add(new Lesson
    //                        {
    //                            Id = sinif12edebiyatId,
    //                            Title = "T�rk Dili Ve Edebiyat�",
    //                            Depth = 4,
    //                            Order = 1,
    //                            ParentId = sinif12sozelId,
    //                            CreatedDate = DateTime.UtcNow,
    //                        });
    //                        #endregion

    //                        #region Tarih
    //                        var sinif12tarihId = Guid.NewGuid();
    //                        seeds.Add(new Lesson
    //                        {
    //                            Id = sinif12tarihId,
    //                            Title = "Tarih",
    //                            Depth = 4,
    //                            Order = 2,
    //                            ParentId = sinif12sozelId,
    //                            CreatedDate = DateTime.UtcNow,
    //                        });
    //                        #endregion

    //                        #region Co�rafya
    //                        var sinif12cografyaId = Guid.NewGuid();
    //                        seeds.Add(new Lesson
    //                        {
    //                            Id = sinif12cografyaId,
    //                            Title = "Co�rafya",
    //                            Depth = 4,
    //                            Order = 3,
    //                            ParentId = sinif12sozelId,
    //                            CreatedDate = DateTime.UtcNow,
    //                        });
    //                        #endregion

    //                        #region Felsefe
    //                        var sinif12felsefeId = Guid.NewGuid();
    //                        seeds.Add(new Lesson
    //                        {
    //                            Id = sinif12felsefeId,
    //                            Title = "Felsefe",
    //                            Depth = 4,
    //                            Order = 4,
    //                            ParentId = sinif12sozelId,
    //                            CreatedDate = DateTime.UtcNow,
    //                        });
    //                        #endregion

    //                        #region Din K�lt�r� Ve Ahlak Bilgisi
    //                        var sinif12dinId = Guid.NewGuid();
    //                        seeds.Add(new Lesson
    //                        {
    //                            Id = sinif12dinId,
    //                            Title = "Din K�lt�r� Ve Ahlak Bilgisi",
    //                            Depth = 4,
    //                            Order = 5,
    //                            ParentId = sinif12sozelId,
    //                            CreatedDate = DateTime.UtcNow,
    //                        });
    //                        #endregion


    //                    #endregion


    //                #endregion

    //        #endregion

    //        #endregion

    //        return seeds;
    //    }
    //}

}