using Domain.Enums;
using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
//TODO: RESIM EKLENECEK
public class Pack : Entity<Guid>
{
    /// <summary>
    /// Paket Başlığı
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Paket açıklaması
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Fiyat
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Para birimi
    /// </summary>
    public PriceCurrency PriceCurrency { get; set; }

    /// <summary>
    /// Vergi oranı
    /// </summary>
    public int TaxRate { get; set; }

}
