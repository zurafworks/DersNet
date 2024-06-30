using NArchitecture.Core.Application.Responses;

namespace Application.Features.Courses.Commands.Create;

public class CreatedCourseResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid GroupId { get; set; }
    public Guid LessonId { get; set; }
    public string Description { get; set; }
}