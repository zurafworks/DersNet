using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class GroupUserConfiguration : IEntityTypeConfiguration<GroupUser>
{
    public void Configure(EntityTypeBuilder<GroupUser> builder)
    {
        builder.ToTable("GroupUsers").HasKey(gu => gu.Id);

        builder.Property(gu => gu.Id).HasColumnName("Id").IsRequired();
        builder.Property(gu => gu.GroupId).HasColumnName("GroupId");
        builder.Property(gu => gu.UserId).HasColumnName("UserId");
        builder.Property(gu => gu.Status).HasColumnName("Status");
        builder.Property(gu => gu.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(gu => gu.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(gu => gu.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(gu => !gu.DeletedDate.HasValue);
    }
}