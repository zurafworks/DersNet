using Application.Features.Lessons.Queries.GetListWithParent;
using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class LessonRepository : EfRepositoryBase<Lesson, Guid, BaseDbContext>, ILessonRepository
{
    public LessonRepository(BaseDbContext context) : base(context)
    {
    }

    public async Task<IPaginate<GetListWithParentItemDto>> GetListWithParentPaginateAsync(int index, int size, CancellationToken cancellationToken)
    {
        var query = from L in Context.Lessons
                    join parentLesson in Context.Lessons on L.ParentId equals parentLesson.Id into parentGroup
                    from parentLesson in parentGroup.DefaultIfEmpty()
                    select new GetListWithParentItemDto
                    {
                        Id = L.Id,
                        ParentId = parentLesson != null ? parentLesson.Id : (Guid?)null,
                        Depth = L.Depth,
                        Order = L.Order,
                        ParentTitle = parentLesson != null ? parentLesson.Title : "",
                        Title = L.Title
                    };
        return await query.ToPaginateAsync(index, size, cancellationToken: cancellationToken);
    }
}