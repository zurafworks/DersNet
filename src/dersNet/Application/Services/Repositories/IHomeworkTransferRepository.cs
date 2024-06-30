using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IHomeworkTransferRepository : IAsyncRepository<HomeworkTransfer, Guid>, IRepository<HomeworkTransfer, Guid>
{
}