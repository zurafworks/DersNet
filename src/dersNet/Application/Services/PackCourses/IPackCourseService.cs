using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.PackCourses;

public interface IPackCourseService
{
    Task<PackCourse?> GetAsync(
        Expression<Func<PackCourse, bool>> predicate,
        Func<IQueryable<PackCourse>, IIncludableQueryable<PackCourse, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<PackCourse>?> GetListAsync(
        Expression<Func<PackCourse, bool>>? predicate = null,
        Func<IQueryable<PackCourse>, IOrderedQueryable<PackCourse>>? orderBy = null,
        Func<IQueryable<PackCourse>, IIncludableQueryable<PackCourse, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<PackCourse> AddAsync(PackCourse packCourse);
    Task<PackCourse> UpdateAsync(PackCourse packCourse);
    Task<PackCourse> DeleteAsync(PackCourse packCourse, bool permanent = false);
}
