using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Lesson : Entity<Guid>
{
    /// <summary>
    /// Ders kategorisi başlığı
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Bağlı olduğu üst başlık
    /// </summary>
    public Guid ParentId { get; set; } = default!;

    /// <summary>
    /// derinlik
    /// 0 için sınıf düzeyleri
    /// 1 için ders türleri matematik türkçe vb
    /// 2 için konu başlıkları
    /// 3 ve devamı için hiyerarşik şekilde konu içerik başlıkları
    /// </summary>
    public short Depth { get; set; }

    /// <summary>
    /// kendi kulvarında sıralanması için sıra numarası
    /// </summary>
    public int Order { get; set; }
}
