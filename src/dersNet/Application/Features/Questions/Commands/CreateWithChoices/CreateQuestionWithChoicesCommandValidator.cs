using FluentValidation;

namespace Application.Features.Questions.Commands.Create;

public class CreateQuestionWithChoicesCommandValidator : AbstractValidator<CreateQuestionWithChoicesCommand>
{
    public CreateQuestionWithChoicesCommandValidator()
    {
        RuleFor(c => c.Question.LessonId).NotEmpty();

        RuleFor(c => c).Must(c => !string.IsNullOrEmpty(c.Question.Text) || !string.IsNullOrEmpty(c.Question.Image))
            .WithMessage("Soru için Resim veya Metin Ýçeriklerinden en az biri olmalýdýr!");

        RuleForEach(c => c.Choices).ChildRules(choices =>
        {
            choices.RuleFor(choice => choice.QuestionId).NotEmpty().WithMessage("Her bir seçeneðin sorusu olmalýdýr.");

            choices.RuleFor(choice => choice)
                .Must(choice => !string.IsNullOrEmpty(choice.Text) || !string.IsNullOrEmpty(choice.Image))
                .WithMessage("Her bir Seçenek için Resim veya Metin Ýçeriklerinden en az biri olmalýdýr!");

            choices.RuleFor(choice => choice.IsAnswer).NotNull().WithMessage("Her bir seçeneðin doðru cevap olup olmadýðý belirtilmelidir.");
        });

        RuleFor(c => c.Choices).Must(choices => choices.Count(x => x.IsAnswer) == 1)
            .WithMessage("Yalnýzca bir tane doðru cevap olmalýdýr.");
    }
}