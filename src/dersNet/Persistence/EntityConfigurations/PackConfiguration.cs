using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class PackConfiguration : IEntityTypeConfiguration<Pack>
{
    public void Configure(EntityTypeBuilder<Pack> builder)
    {
        builder.ToTable("Packs").HasKey(p => p.Id);

        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Title).HasColumnName("Title");
        builder.Property(p => p.Description).HasColumnName("Description");
        builder.Property(p => p.Price).HasColumnName("Price");
        builder.Property(p => p.PriceCurrency).HasColumnName("PriceCurrency");
        builder.Property(p => p.TaxRate).HasColumnName("TaxRate");
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        builder.HasData(_SeedData());
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);

    }
    public static Guid TestId = Guid.NewGuid();
    public List<Pack> _SeedData()
    {
        var _list = new List<Pack>()
        {
            new Pack{Id = TestId, Title = "Fýrsat Paketi", Price = 45, Description="dsa",TaxRate= 0, PriceCurrency = PriceCurrency.TL, CreatedDate= DateTime.Now},
            new Pack{Id = Guid.NewGuid(), Title = "Aile Paketi", Price = 45, Description="dsa",TaxRate= 0, PriceCurrency = PriceCurrency.TL, CreatedDate= DateTime.Now},
            new Pack{Id = Guid.NewGuid(), Title = "Deneme Paketi", Price = 45, Description="dsa",TaxRate= 0, PriceCurrency = PriceCurrency.TL, CreatedDate= DateTime.Now}
        };
        return _list;
    }
}