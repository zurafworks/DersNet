using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class OnBasvuruConfiguration : IEntityTypeConfiguration<OnBasvuru>
{
    public void Configure(EntityTypeBuilder<OnBasvuru> builder)
    {
        builder.ToTable("OnBasvurus").HasKey(ob => ob.Id);

        builder.Property(ob => ob.Id).HasColumnName("Id").IsRequired();
        builder.Property(ob => ob.PackId).HasColumnName("PackId");
        builder.Property(ob => ob.LessonId).HasColumnName("LessonId");
        builder.Property(ob => ob.FirstName).HasColumnName("FirstName");
        builder.Property(ob => ob.LastName).HasColumnName("LastName");
        builder.Property(ob => ob.VeliFirstName).HasColumnName("VeliFirstName");
        builder.Property(ob => ob.VeliLastName).HasColumnName("VeliLastName");
        builder.Property(ob => ob.NotOrtalamasi).HasColumnName("NotOrtalamasi");
        builder.Property(ob => ob.OkulAdi).HasColumnName("OkulAdi");
        builder.Property(ob => ob.VeliCepNo).HasColumnName("VeliCepNo");
        builder.Property(ob => ob.OgrCepNo).HasColumnName("OgrCepNo");
        builder.Property(ob => ob.OgrEmail).HasColumnName("OgrEmail");
        builder.Property(ob => ob.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(ob => ob.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(ob => ob.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(ob => !ob.DeletedDate.HasValue);
    }
}