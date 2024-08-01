using NArchitecture.Core.Application.Dtos;

namespace Application.Features.PackCourses.Queries.GetList;

public class GetListPackCourseListItemDto : IDto
{
    public Guid Id { get; set; }
    public Guid PackId { get; set; }
    public Guid CourseId { get; set; }
}