using Application.Features.Exams.Queries.GetList;
using Application.Features.GroupUsers.Queries.GetList;
using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;
using System.Linq.Expressions;

namespace Persistence.Repositories;

public class ExamRepository : EfRepositoryBase<Exam, Guid, BaseDbContext>, IExamRepository
{
    public ExamRepository(BaseDbContext context) : base(context)
    {
    }

   /// <summary>
   /// Exam list dönen method
   /// </summary>
   /// <param name="index"></param>
   /// <param name="size"></param>
   /// <param name="cancellationToken"></param>
   /// <returns></returns>
    public async Task<IPaginate<GetListExamListItemDto>> GetExamList(int index, int size, CancellationToken cancellationToken)
    {
        var query = from LE in Context.Lessons
                    join E in Context.Exams.DefaultIfEmpty()
                    on LE.Id equals E.LessonId

                    select new GetListExamListItemDto
                    {
                        Id = E.Id,
                        Title = E.Title,
                        Description = E.Description,
                        Duration = E.Duration,

                        LessonId = LE.Id,
                        LessonTitle = LE.Title,
                    };

        return await query.ToPaginateAsync(index, size, cancellationToken: cancellationToken);
    }
}