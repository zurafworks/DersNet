using FluentValidation;

namespace Application.Features.OnBasvurus.Commands.Create;

public class CreateOnBasvuruCommandValidator : AbstractValidator<CreateOnBasvuruCommand>
{
    public CreateOnBasvuruCommandValidator()
    {
        RuleFor(c => c.PackId).NotEmpty();
        RuleFor(c => c.LessonId).NotEmpty();
        RuleFor(c => c.FirstName).NotEmpty();
        RuleFor(c => c.LastName).NotEmpty();
        RuleFor(c => c.VeliFirstName).NotEmpty();
        RuleFor(c => c.VeliLastName).NotEmpty();
        RuleFor(c => c.NotOrtalamasi).NotEmpty();
        RuleFor(c => c.OkulAdi).NotEmpty();
        RuleFor(c => c.VeliCepNo).NotEmpty();
        RuleFor(c => c.OgrCepNo).NotEmpty();
    }
}