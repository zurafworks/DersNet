using NArchitecture.Core.Application.Dtos;
using Domain.Enums;

namespace Application.Features.Packs.Queries.GetList;

public class GetListPackListItemDto : IDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public PriceCurrency PriceCurrency { get; set; }
    public string PriceCurrencyStr { get; set; }
    public int TaxRate { get; set; }
}