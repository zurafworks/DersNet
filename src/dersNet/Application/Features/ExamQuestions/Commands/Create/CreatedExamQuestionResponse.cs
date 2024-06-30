using NArchitecture.Core.Application.Responses;

namespace Application.Features.ExamQuestions.Commands.Create;

public class CreatedExamQuestionResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid ExamId { get; set; }
    public Guid QuestionId { get; set; }
}