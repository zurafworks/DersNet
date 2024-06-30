using NArchitecture.Core.Application.Responses;

namespace Application.Features.Exams.Commands.Update;

public class UpdatedExamResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid LessonId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public TimeSpan Duration { get; set; }
}