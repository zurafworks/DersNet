using NArchitecture.Core.Application.Responses;

namespace Application.Features.Lessons.Commands.Update;

public class UpdatedLessonResponse : IResponse
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public Guid ParentId { get; set; }
    public short Depth { get; set; }
    public int Order { get; set; }
}