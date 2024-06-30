using NArchitecture.Core.Application.Responses;

namespace Application.Features.Groups.Commands.Create;

public class CreatedGroupResponse : IResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid LessonId { get; set; }
    public int Quota { get; set; }
    public Guid PackId { get; set; }
}