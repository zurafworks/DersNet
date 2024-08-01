using Application.Features.PackCourses.Commands.Create;
using Application.Features.PackCourses.Commands.Delete;
using Application.Features.PackCourses.Commands.Update;
using Application.Features.PackCourses.Queries.GetById;
using Application.Features.PackCourses.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.PackCourses.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<PackCourse, CreatePackCourseCommand>().ReverseMap();
        CreateMap<PackCourse, CreatedPackCourseResponse>().ReverseMap();
        CreateMap<PackCourse, UpdatePackCourseCommand>().ReverseMap();
        CreateMap<PackCourse, UpdatedPackCourseResponse>().ReverseMap();
        CreateMap<PackCourse, DeletePackCourseCommand>().ReverseMap();
        CreateMap<PackCourse, DeletedPackCourseResponse>().ReverseMap();
        CreateMap<PackCourse, GetByIdPackCourseResponse>().ReverseMap();
        CreateMap<PackCourse, GetListPackCourseListItemDto>().ReverseMap();
        CreateMap<IPaginate<PackCourse>, GetListResponse<GetListPackCourseListItemDto>>().ReverseMap();
    }
}