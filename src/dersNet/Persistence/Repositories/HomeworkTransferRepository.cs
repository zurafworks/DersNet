using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class HomeworkTransferRepository : EfRepositoryBase<HomeworkTransfer, Guid, BaseDbContext>, IHomeworkTransferRepository
{
    public HomeworkTransferRepository(BaseDbContext context) : base(context)
    {
    }
}