using NArchitecture.Core.Application.Responses;

namespace Application.Features.Exams.Commands.Delete;

public class DeletedExamResponse : IResponse
{
    public Guid Id { get; set; }
}