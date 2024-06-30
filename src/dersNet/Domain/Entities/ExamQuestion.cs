using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class ExamQuestion : Entity<Guid>
{
    /// <summary>
    /// Bağlı olduğu sınav
    /// </summary>
    public Guid ExamId { get; set; }

    /// <summary>
    /// Bağlı olduğu soru
    /// </summary>
    public Guid QuestionId { get; set; }
}
