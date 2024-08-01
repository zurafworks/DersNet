using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class PackCourseRepository : EfRepositoryBase<PackCourse, Guid, BaseDbContext>, IPackCourseRepository
{
    public PackCourseRepository(BaseDbContext context) : base(context)
    {
    }
}