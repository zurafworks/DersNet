using Application.Features.Homework.Rules;
using Application.Services.Repositories;
using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.Homework;

public class HomeworkManager : IHomeworkService
{
    private readonly IHomeworkRepository _homeworkRepository;
    private readonly HomeworkBusinessRules _homeworkBusinessRules;

    public HomeworkManager(IHomeworkRepository homeworkRepository, HomeworkBusinessRules homeworkBusinessRules)
    {
        _homeworkRepository = homeworkRepository;
        _homeworkBusinessRules = homeworkBusinessRules;
    }

    public async Task<Homework?> GetAsync(
        Expression<Func<Homework, bool>> predicate,
        Func<IQueryable<Homework>, IIncludableQueryable<Homework, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        Homework? homework = await _homeworkRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return homework;
    }

    public async Task<IPaginate<Homework>?> GetListAsync(
        Expression<Func<Homework, bool>>? predicate = null,
        Func<IQueryable<Homework>, IOrderedQueryable<Homework>>? orderBy = null,
        Func<IQueryable<Homework>, IIncludableQueryable<Homework, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<Homework> homeworkList = await _homeworkRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return homeworkList;
    }

    public async Task<Homework> AddAsync(Homework homework)
    {
        Homework addedHomework = await _homeworkRepository.AddAsync(homework);

        return addedHomework;
    }

    public async Task<Homework> UpdateAsync(Homework homework)
    {
        Homework updatedHomework = await _homeworkRepository.UpdateAsync(homework);

        return updatedHomework;
    }

    public async Task<Homework> DeleteAsync(Homework homework, bool permanent = false)
    {
        Homework deletedHomework = await _homeworkRepository.DeleteAsync(homework);

        return deletedHomework;
    }
}
