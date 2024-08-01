using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IPackCourseRepository : IAsyncRepository<PackCourse, Guid>, IRepository<PackCourse, Guid>
{
}