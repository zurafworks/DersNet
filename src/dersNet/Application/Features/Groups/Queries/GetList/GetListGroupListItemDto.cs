using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Groups.Queries.GetList;

public class GetListGroupListItemDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid LessonId { get; set; }
    public int Quota { get; set; }
    public Guid PackId { get; set; }
}