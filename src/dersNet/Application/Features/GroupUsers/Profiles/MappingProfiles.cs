using Application.Features.GroupUsers.Commands.Create;
using Application.Features.GroupUsers.Commands.Delete;
using Application.Features.GroupUsers.Commands.Update;
using Application.Features.GroupUsers.Queries.GetById;
using Application.Features.GroupUsers.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.GroupUsers.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<GroupUser, CreateGroupUserCommand>().ReverseMap();
        CreateMap<GroupUser, CreatedGroupUserResponse>().ReverseMap();
        CreateMap<GroupUser, UpdateGroupUserCommand>().ReverseMap();
        CreateMap<GroupUser, UpdatedGroupUserResponse>().ReverseMap();
        CreateMap<GroupUser, DeleteGroupUserCommand>().ReverseMap();
        CreateMap<GroupUser, DeletedGroupUserResponse>().ReverseMap();
        CreateMap<GroupUser, GetByIdGroupUserResponse>().ReverseMap();
        CreateMap<GroupUser, GetListGroupUserListItemDto>().ReverseMap();
        CreateMap<IPaginate<GroupUser>, GetListResponse<GetListGroupUserListItemDto>>().ReverseMap();
    }
}