using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class HomeworkRepository : EfRepositoryBase<Homework, Guid, BaseDbContext>, IHomeworkRepository
{
    public HomeworkRepository(BaseDbContext context) : base(context)
    {
    }
}