using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Sessions.Queries.GetList;

public class GetListSessionListItemDto : IDto
{
    public Guid Id { get; set; }
    public int CourseId { get; set; }
    public int Order { get; set; }
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public string Link { get; set; }
    public string Description { get; set; }
    public Guid LessonId { get; set; }
}