using Application.Features.Exams.Queries.GetList;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;
using NArchitecture.Core.Persistence.Repositories;
using System.Linq.Expressions;

namespace Application.Services.Repositories;

public interface IExamRepository : IAsyncRepository<Exam, Guid>, IRepository<Exam, Guid>
{
    Task<IPaginate<GetListExamListItemDto>> GetExamList(int index, int size, CancellationToken cancellationToken);
}