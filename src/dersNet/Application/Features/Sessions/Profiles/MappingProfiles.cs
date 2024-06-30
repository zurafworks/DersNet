using Application.Features.Sessions.Commands.Create;
using Application.Features.Sessions.Commands.Delete;
using Application.Features.Sessions.Commands.Update;
using Application.Features.Sessions.Queries.GetById;
using Application.Features.Sessions.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.Sessions.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Session, CreateSessionCommand>().ReverseMap();
        CreateMap<Session, CreatedSessionResponse>().ReverseMap();
        CreateMap<Session, UpdateSessionCommand>().ReverseMap();
        CreateMap<Session, UpdatedSessionResponse>().ReverseMap();
        CreateMap<Session, DeleteSessionCommand>().ReverseMap();
        CreateMap<Session, DeletedSessionResponse>().ReverseMap();
        CreateMap<Session, GetByIdSessionResponse>().ReverseMap();
        CreateMap<Session, GetListSessionListItemDto>().ReverseMap();
        CreateMap<IPaginate<Session>, GetListResponse<GetListSessionListItemDto>>().ReverseMap();
    }
}