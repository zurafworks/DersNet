using NArchitecture.Core.Application.Responses;

namespace Application.Features.Courses.Queries.GetById;

public class GetByIdCourseResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid GroupId { get; set; }
    public Guid LessonId { get; set; }
    public string Description { get; set; }
}