using NArchitecture.Core.Application.Responses;

namespace Application.Features.OnBasvurus.Commands.Create;

public class CreatedOnBasvuruResponse : IResponse
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
    public string OgrEmail { get; set; }
}