using NArchitecture.Core.Application.Responses;

namespace Application.Features.PackCourses.Queries.GetById;

public class GetByIdPackCourseResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid PackId { get; set; }
    public Guid CourseId { get; set; }
}