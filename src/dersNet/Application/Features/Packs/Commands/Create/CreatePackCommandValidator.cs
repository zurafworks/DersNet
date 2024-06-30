using FluentValidation;

namespace Application.Features.Packs.Commands.Create;

public class CreatePackCommandValidator : AbstractValidator<CreatePackCommand>
{
    public CreatePackCommandValidator()
    {
        RuleFor(c => c.Title).NotEmpty();
        RuleFor(c => c.Description).NotEmpty();
        RuleFor(c => c.Price).NotEmpty();
        RuleFor(c => c.PriceCurrency).NotEmpty();
        RuleFor(c => c.TaxRate).NotEmpty();
    }
}