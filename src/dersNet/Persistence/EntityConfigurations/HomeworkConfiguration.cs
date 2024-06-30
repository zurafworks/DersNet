using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class HomeworkConfiguration : IEntityTypeConfiguration<Homework>
{
    public void Configure(EntityTypeBuilder<Homework> builder)
    {
        builder.ToTable("Homework").HasKey(h => h.Id);

        builder.Property(h => h.Id).HasColumnName("Id").IsRequired();
        builder.Property(h => h.SessionId).HasColumnName("SessionId");
        builder.Property(h => h.Title).HasColumnName("Title");
        builder.Property(h => h.UploadFile).HasColumnName("UploadFile");
        builder.Property(h => h.StartDate).HasColumnName("StartDate");
        builder.Property(h => h.EndDate).HasColumnName("EndDate");
        builder.Property(h => h.Description).HasColumnName("Description");
        builder.Property(h => h.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(h => h.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(h => h.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(h => !h.DeletedDate.HasValue);
    }
}