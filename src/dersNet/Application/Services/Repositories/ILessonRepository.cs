using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface ILessonRepository : IAsyncRepository<Lesson, Guid>, IRepository<Lesson, Guid>
{
}