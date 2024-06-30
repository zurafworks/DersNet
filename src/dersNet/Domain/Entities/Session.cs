using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Session : Entity<Guid>
{
    /// <summary>
    /// Ait olduğu kurs
    /// </summary>
    public int CourseId { get; set; }// oturum hangi kursa ait.

    /// <summary>
    /// Sessionlar arasındaki sıralaması
    /// </summary>
    public int Order { get; set; }

    /// <summary>
    /// Adı
    /// </summary>
    public string Name { get; set; }// Oturumun ismi nedir - 1.oturum vs vs

    /// <summary>
    /// 13:24 23.02.2023
    /// </summary>
    public DateTime StartDate { get; set; }//

    /// <summary>
    /// ders linki
    /// </summary>
    public string Link { get; set; }// dersin yapılacağı link


    [StringLength(350)]
    public string Description { get; set; } // Ders öncesi işlenecek konular vs açıklama.

    /// <summary>
    /// Ait olduğu ders kategorisi
    /// </summary>
    public Guid LessonId { get; set; }
}
