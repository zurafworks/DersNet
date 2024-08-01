using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
//BAŞLIK OLARAK DERSLERİMİZ
public class Course : Entity<Guid>
{
    /// <summary>
    /// Ait olduğu grup
    /// </summary>
    public Guid GroupId { get; set; }

    /// <summary>
    /// Ait olduğu ders kategorisi
    /// </summary>
    public Guid LessonId { get; set; }

    /// <summary>
    /// açıklaması
    /// </summary>
    public string Description { get; set; }
}
