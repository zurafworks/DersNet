using Application.Features.PackCourses.Rules;
using Application.Services.Repositories;
using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.PackCourses;

public class PackCourseManager : IPackCourseService
{
    private readonly IPackCourseRepository _packCourseRepository;
    private readonly PackCourseBusinessRules _packCourseBusinessRules;

    public PackCourseManager(IPackCourseRepository packCourseRepository, PackCourseBusinessRules packCourseBusinessRules)
    {
        _packCourseRepository = packCourseRepository;
        _packCourseBusinessRules = packCourseBusinessRules;
    }

    public async Task<PackCourse?> GetAsync(
        Expression<Func<PackCourse, bool>> predicate,
        Func<IQueryable<PackCourse>, IIncludableQueryable<PackCourse, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        PackCourse? packCourse = await _packCourseRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return packCourse;
    }

    public async Task<IPaginate<PackCourse>?> GetListAsync(
        Expression<Func<PackCourse, bool>>? predicate = null,
        Func<IQueryable<PackCourse>, IOrderedQueryable<PackCourse>>? orderBy = null,
        Func<IQueryable<PackCourse>, IIncludableQueryable<PackCourse, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<PackCourse> packCourseList = await _packCourseRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return packCourseList;
    }

    public async Task<PackCourse> AddAsync(PackCourse packCourse)
    {
        PackCourse addedPackCourse = await _packCourseRepository.AddAsync(packCourse);

        return addedPackCourse;
    }

    public async Task<PackCourse> UpdateAsync(PackCourse packCourse)
    {
        PackCourse updatedPackCourse = await _packCourseRepository.UpdateAsync(packCourse);

        return updatedPackCourse;
    }

    public async Task<PackCourse> DeleteAsync(PackCourse packCourse, bool permanent = false)
    {
        PackCourse deletedPackCourse = await _packCourseRepository.DeleteAsync(packCourse);

        return deletedPackCourse;
    }
}
