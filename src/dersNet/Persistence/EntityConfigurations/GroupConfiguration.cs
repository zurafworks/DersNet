using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class GroupConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.ToTable("Groups").HasKey(g => g.Id);

        builder.Property(g => g.Id).HasColumnName("Id").IsRequired();
        builder.Property(g => g.Name).HasColumnName("Name");
        builder.Property(g => g.LessonId).HasColumnName("LessonId");
        builder.Property(g => g.Quota).HasColumnName("Quota");
        builder.Property(g => g.PackId).HasColumnName("PackId");
        builder.Property(g => g.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(g => g.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(g => g.DeletedDate).HasColumnName("DeletedDate");
        //builder.HasData(_seedData());
        builder.HasQueryFilter(g => !g.DeletedDate.HasValue);
    }
    //public List<Group> _seedData()
    //{
    //    var seedData = new List<Group>()
    //    {
    //        new Group(){Id = Guid.NewGuid(), LessonId = LessonConfiguration.liseId, Name = "Grup Yorum", PackId = PackConfiguration.TestId,Quota=10,CreatedDate=DateTime.Now }

    //    };
    //    return seedData;
    //}
}