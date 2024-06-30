using Application.Features.GroupUsers.Queries.GetList;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using System.Linq.Expressions;

namespace Application.Services.Repositories;

public interface IGroupUserRepository : IAsyncRepository<GroupUser, Guid>, IRepository<GroupUser, Guid>
{
    Task<ICollection<GetListGroupUserListItemDto>> GetGroupUsers(Expression<Func<GroupUser, bool>> predicate = null);
}