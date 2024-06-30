using NArchitecture.Core.Application.Dtos;

namespace Application.Features.ExamQuestions.Queries.GetList;

public class GetListExamQuestionListItemDto : IDto
{
    public Guid Id { get; set; }
    public Guid ExamId { get; set; }
    public Guid QuestionId { get; set; }
}