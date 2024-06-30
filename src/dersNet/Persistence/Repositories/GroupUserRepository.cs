using Application.Features.GroupUsers.Queries.GetList;
using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Internal;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;
using System.Linq;
using System.Linq.Expressions;

namespace Persistence.Repositories;

public class GroupUserRepository : EfRepositoryBase<GroupUser, Guid, BaseDbContext>, IGroupUserRepository
{
    public GroupUserRepository(BaseDbContext context) : base(context)
    {
    }

    public async Task<ICollection<GetListGroupUserListItemDto>> GetGroupUsers(Expression<Func<GroupUser, bool>> predicate = null)
    {
        var query = from GU in Context.GroupUsers
                    join G in Context.Groups.DefaultIfEmpty()
                    on GU.Id equals G.Id
                    join U in Context.Users.DefaultIfEmpty() on GU.Id equals U.Id

                    select new GetListGroupUserListItemDto
                    {
                        Id = GU.Id,
                        GroupId = G.Id,
                        UserId = U.Id,
                        GroupName = G.Name,
                        Quota = G.Quota,
                        FirstName = U.FirstName,
                        LastName = U.LastName,
                        LessonTitle = "",
                        Status = GU.Status,
                    };

        return query.ToList();
    }
}