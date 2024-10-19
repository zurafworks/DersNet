using Domain.Entities;
using NArchitecture.Core.Application.Responses;

namespace Application.Features.Questions.Commands.Create;

public class CreatedQuestionWithChoicesResponse : IResponse
{
    //public Guid Id { get; set; }
    //public Guid LessonId { get; set; }
    //public string Text { get; set; }
    //public string Image { get; set; }

    public Question Question { get; set; }

    public List<Choice> Choices { get; set; }
}