using Application.Features.HomeworkTransfers.Rules;
using Application.Services.Repositories;
using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.HomeworkTransfers;

public class HomeworkTransferManager : IHomeworkTransferService
{
    private readonly IHomeworkTransferRepository _homeworkTransferRepository;
    private readonly HomeworkTransferBusinessRules _homeworkTransferBusinessRules;

    public HomeworkTransferManager(IHomeworkTransferRepository homeworkTransferRepository, HomeworkTransferBusinessRules homeworkTransferBusinessRules)
    {
        _homeworkTransferRepository = homeworkTransferRepository;
        _homeworkTransferBusinessRules = homeworkTransferBusinessRules;
    }

    public async Task<HomeworkTransfer?> GetAsync(
        Expression<Func<HomeworkTransfer, bool>> predicate,
        Func<IQueryable<HomeworkTransfer>, IIncludableQueryable<HomeworkTransfer, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        HomeworkTransfer? homeworkTransfer = await _homeworkTransferRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return homeworkTransfer;
    }

    public async Task<IPaginate<HomeworkTransfer>?> GetListAsync(
        Expression<Func<HomeworkTransfer, bool>>? predicate = null,
        Func<IQueryable<HomeworkTransfer>, IOrderedQueryable<HomeworkTransfer>>? orderBy = null,
        Func<IQueryable<HomeworkTransfer>, IIncludableQueryable<HomeworkTransfer, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<HomeworkTransfer> homeworkTransferList = await _homeworkTransferRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return homeworkTransferList;
    }

    public async Task<HomeworkTransfer> AddAsync(HomeworkTransfer homeworkTransfer)
    {
        HomeworkTransfer addedHomeworkTransfer = await _homeworkTransferRepository.AddAsync(homeworkTransfer);

        return addedHomeworkTransfer;
    }

    public async Task<HomeworkTransfer> UpdateAsync(HomeworkTransfer homeworkTransfer)
    {
        HomeworkTransfer updatedHomeworkTransfer = await _homeworkTransferRepository.UpdateAsync(homeworkTransfer);

        return updatedHomeworkTransfer;
    }

    public async Task<HomeworkTransfer> DeleteAsync(HomeworkTransfer homeworkTransfer, bool permanent = false)
    {
        HomeworkTransfer deletedHomeworkTransfer = await _homeworkTransferRepository.DeleteAsync(homeworkTransfer);

        return deletedHomeworkTransfer;
    }
}
