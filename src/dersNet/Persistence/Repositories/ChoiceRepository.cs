using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;
using System.Linq.Dynamic.Core;

namespace Persistence.Repositories;

public class ChoiceRepository : EfRepositoryBase<Choice, Guid, BaseDbContext>, IChoiceRepository
{
    public ChoiceRepository(BaseDbContext context) : base(context)
    {
    }

    public async Task<List<Choice>> GetListByQuestionId(Guid questionId, CancellationToken cancellationToken)
    {
        return await Context.Choices.Where(c => c.QuestionId == questionId && !c.DeletedDate.HasValue).ToListAsync(cancellationToken);
    }
}
