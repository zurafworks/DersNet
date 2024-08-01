using Application.Features.Courses.Queries.GetList;
using Application.Features.OnBasvurus.Queries.GetById;
using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class OnBasvuruRepository : EfRepositoryBase<OnBasvuru, Guid, BaseDbContext>, IOnBasvuruRepository
{
    public OnBasvuruRepository(BaseDbContext context) : base(context)
    {
    }

    public async Task<GetByIdOnBasvuruResponse> GetByIdOnBasvuruAsync(Guid id)
    {
        var basvuru = await (
            from B in Context.OnBasvurus
            join P in Context.Packs.DefaultIfEmpty()
                on B.PackId equals P.Id
            join L in Context.Lessons.DefaultIfEmpty()
                on B.LessonId equals L.Id
            where B.Id == id
            select new
            {
                B,
                P,
                L
            }).FirstOrDefaultAsync();

        if (basvuru == null)
        {
            return null;
        }

        var courses = await (
            from pc in Context.PackCourses.Where(pc => pc.PackId == basvuru.P.Id)
            join C in Context.Courses.DefaultIfEmpty()
                on pc.CourseId equals C.Id
            join G in Context.Groups.DefaultIfEmpty()
                on C.GroupId equals G.Id into courseGroups
            from courseGroup in courseGroups.DefaultIfEmpty()
            select new GetListCourseListItemDto
            {
                Id = C.Id,
                GroupId = courseGroup.Id
            }).ToListAsync();

        var response = new GetByIdOnBasvuruResponse
        {
            Id = basvuru.B.Id,
            FirstName = basvuru.B.FirstName,
            LastName = basvuru.B.LastName,
            LessonId = basvuru.L.Id,
            LessonTitle = basvuru.L.Title,
            PackId = basvuru.P.Id,
            PackTitle = basvuru.P.Title,
            NotOrtalamasi = basvuru.B.NotOrtalamasi,
            OgrCepNo = basvuru.B.OgrCepNo,
            OkulAdi = basvuru.B.OkulAdi,
            VeliCepNo = basvuru.B.VeliCepNo,
            VeliFirstName = basvuru.B.VeliFirstName,
            VeliLastName = basvuru.B.VeliLastName,
            Courses = courses
        };

        return response;
    }
}