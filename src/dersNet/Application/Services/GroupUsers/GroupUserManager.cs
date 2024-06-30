using Application.Features.GroupUsers.Rules;
using Application.Services.Repositories;
using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.GroupUsers;

public class GroupUserManager : IGroupUserService
{
    private readonly IGroupUserRepository _groupUserRepository;
    private readonly GroupUserBusinessRules _groupUserBusinessRules;

    public GroupUserManager(IGroupUserRepository groupUserRepository, GroupUserBusinessRules groupUserBusinessRules)
    {
        _groupUserRepository = groupUserRepository;
        _groupUserBusinessRules = groupUserBusinessRules;
    }

    public async Task<GroupUser?> GetAsync(
        Expression<Func<GroupUser, bool>> predicate,
        Func<IQueryable<GroupUser>, IIncludableQueryable<GroupUser, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        GroupUser? groupUser = await _groupUserRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return groupUser;
    }

    public async Task<IPaginate<GroupUser>?> GetListAsync(
        Expression<Func<GroupUser, bool>>? predicate = null,
        Func<IQueryable<GroupUser>, IOrderedQueryable<GroupUser>>? orderBy = null,
        Func<IQueryable<GroupUser>, IIncludableQueryable<GroupUser, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<GroupUser> groupUserList = await _groupUserRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return groupUserList;
    }

    public async Task<GroupUser> AddAsync(GroupUser groupUser)
    {
        GroupUser addedGroupUser = await _groupUserRepository.AddAsync(groupUser);

        return addedGroupUser;
    }

    public async Task<GroupUser> UpdateAsync(GroupUser groupUser)
    {
        GroupUser updatedGroupUser = await _groupUserRepository.UpdateAsync(groupUser);

        return updatedGroupUser;
    }

    public async Task<GroupUser> DeleteAsync(GroupUser groupUser, bool permanent = false)
    {
        GroupUser deletedGroupUser = await _groupUserRepository.DeleteAsync(groupUser);

        return deletedGroupUser;
    }
}
