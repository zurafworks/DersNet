using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.Homework;

public interface IHomeworkService
{
    Task<Domain.Entities.Homework?> GetAsync(
        Expression<Func<Domain.Entities.Homework, bool>> predicate,
        Func<IQueryable<Domain.Entities.Homework>, IIncludableQueryable<Domain.Entities.Homework, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<Domain.Entities.Homework>?> GetListAsync(
        Expression<Func<Domain.Entities.Homework, bool>>? predicate = null,
        Func<IQueryable<Domain.Entities.Homework>, IOrderedQueryable<Domain.Entities.Homework>>? orderBy = null,
        Func<IQueryable<Domain.Entities.Homework>, IIncludableQueryable<Domain.Entities.Homework, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<Domain.Entities.Homework> AddAsync(Domain.Entities.Homework homework);
    Task<Domain.Entities.Homework> UpdateAsync(Domain.Entities.Homework homework);
    Task<Domain.Entities.Homework> DeleteAsync(Domain.Entities.Homework homework, bool permanent = false);
}
