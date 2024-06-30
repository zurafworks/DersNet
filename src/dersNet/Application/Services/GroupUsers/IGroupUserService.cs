using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.GroupUsers;

public interface IGroupUserService
{
    Task<GroupUser?> GetAsync(
        Expression<Func<GroupUser, bool>> predicate,
        Func<IQueryable<GroupUser>, IIncludableQueryable<GroupUser, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<GroupUser>?> GetListAsync(
        Expression<Func<GroupUser, bool>>? predicate = null,
        Func<IQueryable<GroupUser>, IOrderedQueryable<GroupUser>>? orderBy = null,
        Func<IQueryable<GroupUser>, IIncludableQueryable<GroupUser, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<GroupUser> AddAsync(GroupUser groupUser);
    Task<GroupUser> UpdateAsync(GroupUser groupUser);
    Task<GroupUser> DeleteAsync(GroupUser groupUser, bool permanent = false);
}
