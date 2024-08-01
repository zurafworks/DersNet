using NArchitecture.Core.Application.Responses;

namespace Application.Features.PackCourses.Commands.Create;

public class CreatedPackCourseResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid PackId { get; set; }
    public Guid CourseId { get; set; }
}