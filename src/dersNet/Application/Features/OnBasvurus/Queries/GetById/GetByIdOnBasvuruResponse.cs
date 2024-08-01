using Application.Features.Courses.Queries.GetList;
using NArchitecture.Core.Application.Responses;

namespace Application.Features.OnBasvurus.Queries.GetById;

public class GetByIdOnBasvuruResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid PackId { get; set; }
    public string PackTitle { get; set; }//Paket'in baþlýðý
    public Guid LessonId { get; set; }
    public string LessonTitle { get; set; }//Öðrencinin eðitim düzeyini gösteren bilgi.
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string VeliFirstName { get; set; }
    public string VeliLastName { get; set; }
    public double NotOrtalamasi { get; set; }
    public string OkulAdi { get; set; }
    public string VeliCepNo { get; set; }
    public string OgrCepNo { get; set; }
    public List<GetListCourseListItemDto> Courses { get; set; } = default!;
}