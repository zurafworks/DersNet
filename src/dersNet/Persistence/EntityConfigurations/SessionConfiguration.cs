using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class SessionConfiguration : IEntityTypeConfiguration<Session>
{
    public void Configure(EntityTypeBuilder<Session> builder)
    {
        builder.ToTable("Sessions").HasKey(s => s.Id);

        builder.Property(s => s.Id).HasColumnName("Id").IsRequired();
        builder.Property(s => s.CourseId).HasColumnName("CourseId");
        builder.Property(s => s.Order).HasColumnName("Order");
        builder.Property(s => s.Name).HasColumnName("Name");
        builder.Property(s => s.StartDate).HasColumnName("StartDate");
        builder.Property(s => s.Link).HasColumnName("Link");
        builder.Property(s => s.Description).HasColumnName("Description");
        builder.Property(s => s.LessonId).HasColumnName("LessonId");
        builder.Property(s => s.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(s => s.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(s => s.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(s => !s.DeletedDate.HasValue);
    }
}