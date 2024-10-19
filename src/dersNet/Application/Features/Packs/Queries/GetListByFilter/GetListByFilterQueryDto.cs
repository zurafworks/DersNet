using Domain.Entities;
using Domain.Enums;
using NArchitecture.Core.Application.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Packs.Queries.GetListByFilter;
public class GetListByFilterQueryDto : PageRequest
{
    public string? Filter { get; set; }
    public string? Group { get; set; }
    //public string? Title { get; set; }
    //public decimal? Price { get; set; }
    //public PriceCurrency? PriceCurrency { get; set; }
}
