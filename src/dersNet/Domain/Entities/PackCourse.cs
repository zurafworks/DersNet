using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
/// <summary>
/// Paketteki kursların neler olacağını gösteren tablo
/// </summary>
public class PackCourse : Entity<Guid>
{
    public Guid PackId { get; set; }
    public Guid CourseId { get; set; }
}
