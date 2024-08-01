using NArchitecture.Core.Application.Responses;

namespace Application.Features.PackCourses.Commands.Update;

public class UpdatedPackCourseResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid PackId { get; set; }
    public Guid CourseId { get; set; }
}