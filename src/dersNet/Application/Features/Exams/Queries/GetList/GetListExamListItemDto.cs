using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Exams.Queries.GetList;

public class GetListExamListItemDto : IDto
{
    public Guid Id { get; set; }
    public Guid LessonId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public TimeSpan Duration { get; set; }
}