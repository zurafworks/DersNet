using Application.Features.Groups.Queries.GetById;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IGroupRepository : IAsyncRepository<Group, Guid>, IRepository<Group, Guid>
{
    /// <summary>
    /// GetByIdGroupResponse i�in gerekli join i�lemlerini i�erir.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<GetByIdGroupResponse> GetGroupResponseWithLessonsAndPacks(Guid? id);
}