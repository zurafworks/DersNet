using NArchitecture.Core.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.OnBasvurus.Queries.GetListWithStrings;
public class GetListOnBasvuruWithStringsListItemDto : IDto
{
    public Guid Id { get; set; }
    public Guid PackId { get; set; }
    public string PackName { get; set; }
    public Guid LessonId { get; set; }
    public string LessonName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string VeliFirstName { get; set; }
    public string VeliLastName { get; set; }
    public double NotOrtalamasi { get; set; }
    public string OkulAdi { get; set; }
    public string VeliCepNo { get; set; }
    public string OgrCepNo { get; set; }
    public string OgrEmail { get; set; }
}
