using NArchitecture.Core.Application.Responses;

namespace Application.Features.PackCourses.Commands.Delete;

public class DeletedPackCourseResponse : IResponse
{
    public Guid Id { get; set; }
}