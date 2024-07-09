using NArchitecture.Core.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Lessons.Queries.GetListWithParent;
public class GetListWithParentItemDto : IDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public Guid? ParentId { get; set; }
    public string ParentTitle { get; set; }
    public short Depth { get; set; }
    public int Order { get; set; }
}
