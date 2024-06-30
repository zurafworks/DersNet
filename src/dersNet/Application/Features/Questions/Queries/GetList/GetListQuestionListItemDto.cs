using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Questions.Queries.GetList;

public class GetListQuestionListItemDto : IDto
{
    public Guid Id { get; set; }
    public Guid LessonId { get; set; }
    public string Text { get; set; }
    public string Image { get; set; }
}