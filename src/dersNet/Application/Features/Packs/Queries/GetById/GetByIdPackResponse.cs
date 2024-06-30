using NArchitecture.Core.Application.Responses;
using Domain.Enums;

namespace Application.Features.Packs.Queries.GetById;

public class GetByIdPackResponse : IResponse
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public PriceCurrency PriceCurrency { get; set; }
    public int TaxRate { get; set; }
}