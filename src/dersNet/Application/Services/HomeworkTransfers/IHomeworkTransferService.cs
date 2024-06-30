using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.HomeworkTransfers;

public interface IHomeworkTransferService
{
    Task<HomeworkTransfer?> GetAsync(
        Expression<Func<HomeworkTransfer, bool>> predicate,
        Func<IQueryable<HomeworkTransfer>, IIncludableQueryable<HomeworkTransfer, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<HomeworkTransfer>?> GetListAsync(
        Expression<Func<HomeworkTransfer, bool>>? predicate = null,
        Func<IQueryable<HomeworkTransfer>, IOrderedQueryable<HomeworkTransfer>>? orderBy = null,
        Func<IQueryable<HomeworkTransfer>, IIncludableQueryable<HomeworkTransfer, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<HomeworkTransfer> AddAsync(HomeworkTransfer homeworkTransfer);
    Task<HomeworkTransfer> UpdateAsync(HomeworkTransfer homeworkTransfer);
    Task<HomeworkTransfer> DeleteAsync(HomeworkTransfer homeworkTransfer, bool permanent = false);
}
