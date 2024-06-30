using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.Packs;

public interface IPackService
{
    Task<Pack?> GetAsync(
        Expression<Func<Pack, bool>> predicate,
        Func<IQueryable<Pack>, IIncludableQueryable<Pack, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<Pack>?> GetListAsync(
        Expression<Func<Pack, bool>>? predicate = null,
        Func<IQueryable<Pack>, IOrderedQueryable<Pack>>? orderBy = null,
        Func<IQueryable<Pack>, IIncludableQueryable<Pack, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<Pack> AddAsync(Pack pack);
    Task<Pack> UpdateAsync(Pack pack);
    Task<Pack> DeleteAsync(Pack pack, bool permanent = false);
}
