using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IHomeworkRepository : IAsyncRepository<Homework, Guid>, IRepository<Homework, Guid>
{
}