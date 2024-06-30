using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Courses.Queries.GetList;

public class GetListCourseListItemDto : IDto
{
    public Guid Id { get; set; }
    public Guid GroupId { get; set; }
    public Guid LessonId { get; set; }
    public string Description { get; set; }
}