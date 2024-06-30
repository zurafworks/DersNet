using Domain.Enums;
using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class GroupUser : Entity<Guid>
{
    /// <summary>
    /// Bağlı olduğu grup
    /// </summary>
    public Guid GroupId { get; set; }

    /// <summary>
    /// Bağlı olduğu Kullanıcı
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Bağlı kullanıının türü öğrenci çğretmen danışman vb
    /// </summary>
    public UserStatus Status { get; set; }
}
