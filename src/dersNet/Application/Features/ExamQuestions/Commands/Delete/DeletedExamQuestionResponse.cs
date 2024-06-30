using NArchitecture.Core.Application.Responses;

namespace Application.Features.ExamQuestions.Commands.Delete;

public class DeletedExamQuestionResponse : IResponse
{
    public Guid Id { get; set; }
}