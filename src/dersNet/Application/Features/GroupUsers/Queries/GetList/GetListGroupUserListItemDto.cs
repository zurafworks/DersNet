using NArchitecture.Core.Application.Dtos;
using Domain.Enums;

namespace Application.Features.GroupUsers.Queries.GetList;

public class GetListGroupUserListItemDto : IDto
{
    public Guid Id { get; set; }
    public Guid GroupId { get; set; }
    public string GroupName { get; set; }
    public int Quota { get; set; }
    public Guid UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public UserStatus Status { get; set; }
    public string LessonTitle { get; set; }//Lessondan çekecem

}