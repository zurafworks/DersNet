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

    public async Task<Domain.Entities.Homework?> GetAsync(
        Expression<Func<Domain.Entities.Homework, bool>> predicate,
        Func<IQueryable<Domain.Entities.Homework>, IIncludableQueryable<Domain.Entities.Homework, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        Domain.Entities.Homework? homework = await _homeworkRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return homework;
    }

    public async Task<IPaginate<Domain.Entities.Homework>?> GetListAsync(
        Expression<Func<Domain.Entities.Homework, bool>>? predicate = null,
        Func<IQueryable<Domain.Entities.Homework>, IOrderedQueryable<Domain.Entities.Homework>>? orderBy = null,
        Func<IQueryable<Domain.Entities.Homework>, IIncludableQueryable<Domain.Entities.Homework, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<Domain.Entities.Homework> homeworkList = await _homeworkRepository.GetListAsync(
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

    public async Task<Domain.Entities.Homework> AddAsync(Domain.Entities.Homework homework)
    {
        Domain.Entities.Homework addedHomework = await _homeworkRepository.AddAsync(homework);

        return addedHomework;
    }

    public async Task<Domain.Entities.Homework> UpdateAsync(Domain.Entities.Homework homework)
    {
        Domain.Entities.Homework updatedHomework = await _homeworkRepository.UpdateAsync(homework);

        return updatedHomework;
    }

    public async Task<Domain.Entities.Homework> DeleteAsync(Domain.Entities.Homework homework, bool permanent = false)
    {
        Domain.Entities.Homework deletedHomework = await _homeworkRepository.DeleteAsync(homework);

        return deletedHomework;
    }
}
