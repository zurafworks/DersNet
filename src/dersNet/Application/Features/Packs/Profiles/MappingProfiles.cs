using Application.Features.Packs.Commands.Create;
using Application.Features.Packs.Commands.Delete;
using Application.Features.Packs.Commands.Update;
using Application.Features.Packs.Queries.GetById;
using Application.Features.Packs.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.Packs.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Pack, CreatePackCommand>().ReverseMap();
        CreateMap<Pack, CreatedPackResponse>().ReverseMap();
        CreateMap<Pack, UpdatePackCommand>().ReverseMap();
        CreateMap<Pack, UpdatedPackResponse>().ReverseMap();
        CreateMap<Pack, DeletePackCommand>().ReverseMap();
        CreateMap<Pack, DeletedPackResponse>().ReverseMap();
        CreateMap<Pack, GetByIdPackResponse>().ReverseMap();
        CreateMap<Pack, GetListPackListItemDto>().ReverseMap();
        CreateMap<IPaginate<Pack>, GetListResponse<GetListPackListItemDto>>().ReverseMap();
    }
}