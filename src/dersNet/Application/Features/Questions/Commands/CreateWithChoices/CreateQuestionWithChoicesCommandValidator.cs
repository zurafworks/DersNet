using FluentValidation;

namespace Application.Features.Questions.Commands.Create;

public class CreateQuestionWithChoicesCommandValidator : AbstractValidator<CreateQuestionWithChoicesCommand>
{
    public CreateQuestionWithChoicesCommandValidator()
    {
        RuleFor(c => c.Question.LessonId).NotEmpty();

        RuleFor(c => c).Must(c => !string.IsNullOrEmpty(c.Question.Text) || !string.IsNullOrEmpty(c.Question.Image))
            .WithMessage("Soru i�in Resim veya Metin ��eriklerinden en az biri olmal�d�r!");

        RuleForEach(c => c.Choices).ChildRules(choices =>
        {
            choices.RuleFor(choice => choice.QuestionId).NotEmpty().WithMessage("Her bir se�ene�in sorusu olmal�d�r.");

            choices.RuleFor(choice => choice)
                .Must(choice => !string.IsNullOrEmpty(choice.Text) || !string.IsNullOrEmpty(choice.Image))
                .WithMessage("Her bir Se�enek i�in Resim veya Metin ��eriklerinden en az biri olmal�d�r!");

            choices.RuleFor(choice => choice.IsAnswer).NotNull().WithMessage("Her bir se�ene�in do�ru cevap olup olmad��� belirtilmelidir.");
        });

        RuleFor(c => c.Choices).Must(choices => choices.Count(x => x.IsAnswer) == 1)
            .WithMessage("Yaln�zca bir tane do�ru cevap olmal�d�r.");
    }
}