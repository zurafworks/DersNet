using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.OnBasvurus;

public interface IOnBasvuruService
{
    Task<OnBasvuru?> GetAsync(
        Expression<Func<OnBasvuru, bool>> predicate,
        Func<IQueryable<OnBasvuru>, IIncludableQueryable<OnBasvuru, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<OnBasvuru>?> GetListAsync(
        Expression<Func<OnBasvuru, bool>>? predicate = null,
        Func<IQueryable<OnBasvuru>, IOrderedQueryable<OnBasvuru>>? orderBy = null,
        Func<IQueryable<OnBasvuru>, IIncludableQueryable<OnBasvuru, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<OnBasvuru> AddAsync(OnBasvuru onBasvuru);
    Task<OnBasvuru> UpdateAsync(OnBasvuru onBasvuru);
    Task<OnBasvuru> DeleteAsync(OnBasvuru onBasvuru, bool permanent = false);
}
