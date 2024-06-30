using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class ExamQuestionRepository : EfRepositoryBase<ExamQuestion, Guid, BaseDbContext>, IExamQuestionRepository
{
    public ExamQuestionRepository(BaseDbContext context) : base(context)
    {
    }
}