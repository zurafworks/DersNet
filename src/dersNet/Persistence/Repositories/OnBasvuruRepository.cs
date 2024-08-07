using Application.Features.Courses.Queries.GetList;
using Application.Features.Lessons.Queries.GetListWithParent;
using Application.Features.OnBasvurus.Queries.GetById;
using Application.Features.OnBasvurus.Queries.GetListWithStrings;
using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Persistence.Paging;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class OnBasvuruRepository : EfRepositoryBase<OnBasvuru, Guid, BaseDbContext>, IOnBasvuruRepository
{
    public OnBasvuruRepository(BaseDbContext context) : base(context)
    {
    }

    public async Task<IPaginate<GetListOnBasvuruWithStringsListItemDto>> GetListOnBasvuruWithStringsPaginateAsync(int index, int size, CancellationToken cancellationToken)
    {
        var query = from onBasvuru in Context.OnBasvurus
                    join pack in Context.Packs on onBasvuru.PackId equals pack.Id 
                    join lesson in Context.Lessons on onBasvuru.LessonId equals lesson.Id 
                    select new GetListOnBasvuruWithStringsListItemDto
                    {
                        Id = onBasvuru.Id,
                        PackId = onBasvuru.PackId,
                        PackName = pack.Title,
                        LessonId = onBasvuru.LessonId,
                        LessonName = lesson.Title,
                        FirstName = onBasvuru.FirstName,
                        LastName = onBasvuru.LastName,
                        VeliFirstName = onBasvuru.VeliFirstName,
                        VeliLastName = onBasvuru.VeliLastName,
                        NotOrtalamasi = onBasvuru.NotOrtalamasi,
                        OkulAdi = onBasvuru.OkulAdi,
                        VeliCepNo = onBasvuru.VeliCepNo,
                        OgrCepNo = onBasvuru.OgrCepNo,
                        OgrEmail = onBasvuru.OgrEmail,
                    };
        return await query.ToPaginateAsync(index, size, cancellationToken: cancellationToken);
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
            OgrEmail = basvuru.B.OgrEmail,
            OkulAdi = basvuru.B.OkulAdi,
            VeliCepNo = basvuru.B.VeliCepNo,
            VeliFirstName = basvuru.B.VeliFirstName,
            VeliLastName = basvuru.B.VeliLastName,
            Courses = courses
        };

        return response;
    }
}