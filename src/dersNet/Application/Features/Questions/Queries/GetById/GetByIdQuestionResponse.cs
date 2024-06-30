using NArchitecture.Core.Application.Responses;

namespace Application.Features.Questions.Queries.GetById;

public class GetByIdQuestionResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid LessonId { get; set; }
    public string Text { get; set; }
    public string Image { get; set; }
}