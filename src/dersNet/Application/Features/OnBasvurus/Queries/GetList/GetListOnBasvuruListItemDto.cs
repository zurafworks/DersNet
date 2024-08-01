using NArchitecture.Core.Application.Dtos;

namespace Application.Features.OnBasvurus.Queries.GetList;

public class GetListOnBasvuruListItemDto : IDto
{
    public Guid Id { get; set; }
    public Guid PackId { get; set; }
    public Guid LessonId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string VeliFirstName { get; set; }
    public string VeliLastName { get; set; }
    public double NotOrtalamasi { get; set; }
    public string OkulAdi { get; set; }
    public string VeliCepNo { get; set; }
    public string OgrCepNo { get; set; }
}