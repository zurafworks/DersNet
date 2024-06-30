using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class HomeworkTransferConfiguration : IEntityTypeConfiguration<HomeworkTransfer>
{
    public void Configure(EntityTypeBuilder<HomeworkTransfer> builder)
    {
        builder.ToTable("HomeworkTransfers").HasKey(ht => ht.Id);

        builder.Property(ht => ht.Id).HasColumnName("Id").IsRequired();
        builder.Property(ht => ht.HomeworkId).HasColumnName("HomeworkId");
        builder.Property(ht => ht.StudentId).HasColumnName("StudentId");
        builder.Property(ht => ht.Status).HasColumnName("Status");
        builder.Property(ht => ht.Description).HasColumnName("Description");
        builder.Property(ht => ht.Attachment).HasColumnName("Attachment");
        builder.Property(ht => ht.TransferDate).HasColumnName("TransferDate");
        builder.Property(ht => ht.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(ht => ht.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(ht => ht.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(ht => !ht.DeletedDate.HasValue);
    }
}