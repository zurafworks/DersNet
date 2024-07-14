using Application.Features.Lessons.Queries.GetById;
using Application.Features.Lessons.Queries.GetListWithParent;
using Application.Features.Packs.Queries.GetById;
using NArchitecture.Core.Application.Responses;

namespace Application.Features.Groups.Queries.GetById;

public class GetByIdGroupResponse : IResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid LessonId { get; set; }
    public int Quota { get; set; }
    public Guid PackId { get; set; }
    public List<GetByIdPackResponse> Packs { get; set; } = default!;
    public List<GetListWithParentItemDto> Lessons { get; set; } = default!;
}