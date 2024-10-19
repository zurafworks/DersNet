using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Group : Entity<Guid>
{
    /// <summary>
    /// Grup Adı
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Ait olduğu ders kategorisi(sınıf düzeyi)
    /// </summary>
    public Guid LessonId { get; set; }

    /// <summary>
    /// Grup kotası
    /// </summary>
    public int Quota { get; set; }

    /// <summary>
    /// Ait olduğu paket
    /// </summary>
    public Guid PackId { get; set; }
}
