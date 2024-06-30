using NArchitecture.Core.Application.Responses;
using Domain.Enums;

namespace Application.Features.Packs.Commands.Create;

public class CreatedPackResponse : IResponse
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public PriceCurrency PriceCurrency { get; set; }
    public int TaxRate { get; set; }
}