using NArchitecture.Core.Application.Responses;

namespace Application.Features.Choices.Commands.Update;

public class UpdatedChoiceResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid QuestionId { get; set; }
    public string Text { get; set; }
    public string Image { get; set; }
    public bool IsAnswer { get; set; }
}