using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IExamQuestionRepository : IAsyncRepository<ExamQuestion, Guid>, IRepository<ExamQuestion, Guid>
{
}