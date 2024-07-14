using Application.Features.Groups.Queries.GetById;
using Application.Features.Lessons.Queries.GetById;
using Application.Features.Lessons.Queries.GetListWithParent;
using Application.Features.Packs.Queries.GetById;
using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class GroupRepository : EfRepositoryBase<Group, Guid, BaseDbContext>, IGroupRepository
{
    public GroupRepository(BaseDbContext context) : base(context)
    {
    }

    public async Task<GetByIdGroupResponse> GetGroupResponseWithLessonsAndPacks(Guid? id)
    {
        //Kullanýcý id'yi null olarak gönderse bile Paketler ve Gruplar return edilmeli.
        //Yeni Kayýt eklerken Dropdownlarýn dolu gelmesi için yazýldý.
        var packsTask = Context.Packs.Select(x => new GetByIdPackResponse
        {
            Id = x.Id,
            Description = x.Description,
            Price = x.Price,
            PriceCurrency = x.PriceCurrency,
            TaxRate = x.TaxRate,
            Title = x.Title,
        }).ToListAsync();

        var lessonsTask = (from Less in Context.Lessons
                           join parentLesson in Context.Lessons on Less.ParentId equals parentLesson.Id into parentGroup
                           from parentLesson in parentGroup.DefaultIfEmpty()
                           select new GetListWithParentItemDto
                           {
                               Id = Less.Id,
                               ParentId = parentLesson.Id,
                               Depth = Less.Depth,
                               Order = Less.Order,
                               ParentTitle = parentLesson.Title ?? "",
                               Title = Less.Title
                           }).ToListAsync();

        // Packs ve Lessons verilerini bekleyerek alýyoruz.
        var packs = await packsTask;
        var lessons = await lessonsTask;
        if (id == null)
        {
            // Eðer id null ise, boþ bir GetByIdGroupResponse döndürüyoruz.
            return new GetByIdGroupResponse
            {
                Lessons = lessons,
                Packs = packs
            };
        }

        // Packs ve Lessons verilerini paralel olarak alýyoruz.
        

        // Query sorgusunu veritabanýna yapýyoruz ve sonuçlarý alýyoruz.
        var query = await (from G in Context.Groups
                           where G.Id == id
                           join P in Context.Packs on G.PackId equals P.Id into packGroup
                           from P in packGroup.DefaultIfEmpty()
                           join L in Context.Lessons on G.LessonId equals L.Id into lessonGroup
                           from L in lessonGroup.DefaultIfEmpty()
                           select new GetByIdGroupResponse
                           {
                               Id = G.Id,
                               LessonId = L.Id,
                               PackId = P.Id,
                               Name = G.Name,
                               Quota = G.Quota,
                               Packs = packs,
                               Lessons = lessons
                           }).FirstOrDefaultAsync();

        // Query null olabilir, bu nedenle null kontrolü yaparak varsayýlan deðeri döndürüyoruz.
        return query ?? new GetByIdGroupResponse
        {
            Lessons = lessons,
            Packs = packs
        };
    }
}