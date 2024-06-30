using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Choices.Queries.GetList;

public class GetListChoiceListItemDto : IDto
{
    public Guid Id { get; set; }
    public Guid QuestionId { get; set; }
    public string Text { get; set; }
    public string Image { get; set; }
    public bool IsAnswer { get; set; }
}