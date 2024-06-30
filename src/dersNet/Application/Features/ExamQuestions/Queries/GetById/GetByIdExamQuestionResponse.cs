using NArchitecture.Core.Application.Responses;

namespace Application.Features.ExamQuestions.Queries.GetById;

public class GetByIdExamQuestionResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid ExamId { get; set; }
    public Guid QuestionId { get; set; }
}