using NArchitecture.Core.Application.Responses;

namespace Application.Features.Homework.Commands.Update;

public class UpdatedHomeworkResponse : IResponse
{
    public Guid Id { get; set; }
    public int SessionId { get; set; }
    public string Title { get; set; }
    public string UploadFile { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Description { get; set; }
}