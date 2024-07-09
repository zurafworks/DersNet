using Application.Features.Lessons.Queries.GetListWithParent;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface ILessonRepository : IAsyncRepository<Lesson, Guid>, IRepository<Lesson, Guid>
{
    Task<IPaginate<GetListWithParentItemDto>> GetListWithParentPaginateAsync(int index, int size, CancellationToken cancellationToken);
}