using Application.Features.OnBasvurus.Commands.Create;
using Application.Features.OnBasvurus.Commands.Delete;
using Application.Features.OnBasvurus.Commands.Update;
using Application.Features.OnBasvurus.Queries.GetById;
using Application.Features.OnBasvurus.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.OnBasvurus.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<OnBasvuru, CreateOnBasvuruCommand>().ReverseMap();
        CreateMap<OnBasvuru, CreatedOnBasvuruResponse>().ReverseMap();
        CreateMap<OnBasvuru, UpdateOnBasvuruCommand>().ReverseMap();
        CreateMap<OnBasvuru, UpdatedOnBasvuruResponse>().ReverseMap();
        CreateMap<OnBasvuru, DeleteOnBasvuruCommand>().ReverseMap();
        CreateMap<OnBasvuru, DeletedOnBasvuruResponse>().ReverseMap();
        CreateMap<OnBasvuru, GetByIdOnBasvuruResponse>().ReverseMap();
        CreateMap<OnBasvuru, GetListOnBasvuruListItemDto>().ReverseMap();
        CreateMap<IPaginate<OnBasvuru>, GetListResponse<GetListOnBasvuruListItemDto>>().ReverseMap();
    }
}