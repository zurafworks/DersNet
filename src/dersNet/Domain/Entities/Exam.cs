using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Exam : Entity<Guid>
{
    /// <summary>
    /// Ait olduğu ders kategorisi
    /// </summary>
    public Guid LessonId { get; set; }

    /// <summary>
    /// Başlık
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Açıklama
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Sınav süresi
    /// </summary>
    public TimeSpan Duration { get; set; } //minute
}
