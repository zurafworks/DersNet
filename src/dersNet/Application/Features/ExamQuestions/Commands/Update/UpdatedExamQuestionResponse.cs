using NArchitecture.Core.Application.Responses;

namespace Application.Features.ExamQuestions.Commands.Update;

public class UpdatedExamQuestionResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid ExamId { get; set; }
    public Guid QuestionId { get; set; }
}