using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IHomeworkRepository : IAsyncRepository<Domain.Entities.Homework, Guid>, IRepository<Domain.Entities.Homework, Guid>
{
}