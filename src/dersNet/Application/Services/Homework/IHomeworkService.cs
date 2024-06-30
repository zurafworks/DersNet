using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.Homework;

public interface IHomeworkService
{
    Task<Homework?> GetAsync(
        Expression<Func<Homework, bool>> predicate,
        Func<IQueryable<Homework>, IIncludableQueryable<Homework, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<Homework>?> GetListAsync(
        Expression<Func<Homework, bool>>? predicate = null,
        Func<IQueryable<Homework>, IOrderedQueryable<Homework>>? orderBy = null,
        Func<IQueryable<Homework>, IIncludableQueryable<Homework, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<Homework> AddAsync(Homework homework);
    Task<Homework> UpdateAsync(Homework homework);
    Task<Homework> DeleteAsync(Homework homework, bool permanent = false);
}
