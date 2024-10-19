using Application.Features.Lessons.Queries.GetListWithParent;
using Application.Features.Questions.Queries.GetListWithChoices;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;
using NArchitecture.Core.Persistence.Repositories;
using Nest;

namespace Application.Services.Repositories;

public interface IQuestionRepository : IAsyncRepository<Question, Guid>, IRepository<Question, Guid>
{
    public Task<Question> AddQuestionWithChoices(Question question, List<Choice> choices, CancellationToken cancellationToken);

    public Task<Question> UpdateQuestionWithChoices(Question question, List<Choice> choices, CancellationToken cancellationToken);

    Task<IPaginate<GetListQuestionWithChoicesListItemDto>> GetListWithChoicesPaginateAsync(int index, int size, CancellationToken cancellationToken);
}