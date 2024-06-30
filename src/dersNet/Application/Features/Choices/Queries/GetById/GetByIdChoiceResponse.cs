using NArchitecture.Core.Application.Responses;

namespace Application.Features.Choices.Queries.GetById;

public class GetByIdChoiceResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid QuestionId { get; set; }
    public string Text { get; set; }
    public string Image { get; set; }
    public bool IsAnswer { get; set; }
}