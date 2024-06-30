using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Question : Entity<Guid>
{
    /// <summary>
    /// Ait olduğu kurs
    /// </summary>
    public Guid LessonId { get; set; }

    /// <summary>
    /// Soru cümlesi (text editor ile yapılacak ve json formatında tutualcak)
    /// </summary>
    public string Text { get; set; } //devextreme text editor json

    /// <summary>
    /// soru resmi veya resimleri (çoklu resim olması dahilinde , ile split olabilecek)
    /// </summary>
    public string Image { get; set; } //split edilebilir
}
