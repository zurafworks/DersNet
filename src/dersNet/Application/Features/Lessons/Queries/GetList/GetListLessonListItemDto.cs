using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Lessons.Queries.GetList;

public class GetListLessonListItemDto : IDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public Guid ParentId { get; set; }
    public short Depth { get; set; }
    public int Order { get; set; }
}