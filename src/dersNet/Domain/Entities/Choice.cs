using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Choice : Entity<Guid>
{
    /// <summary>
    /// Ait olduğu soru
    /// </summary>
    public Guid QuestionId { get; set; }

    /// <summary>
    /// cevap içeriği
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// cevap resmi
    /// </summary>
    public string Image { get; set; }

    /// <summary>
    /// doğru cevap mı?
    /// </summary>
    public bool IsAnswer { get; set; }
}
