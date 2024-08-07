using FluentValidation;

namespace Application.Features.OnBasvurus.Commands.Update;

public class UpdateOnBasvuruCommandValidator : AbstractValidator<UpdateOnBasvuruCommand>
{
    public UpdateOnBasvuruCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
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
        RuleFor(c => c.OgrEmail).NotEmpty();
    }
}