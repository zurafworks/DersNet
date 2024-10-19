using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IChoiceRepository : IAsyncRepository<Choice, Guid>, IRepository<Choice, Guid>
{
    public Task<List<Choice>> GetListByQuestionId(Guid questionId, CancellationToken cancellationToken);
}
