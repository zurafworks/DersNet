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
        //Kullan�c� id'yi null olarak g�nderse bile Paketler ve Gruplar return edilmeli.
        //Yeni Kay�t eklerken Dropdownlar�n dolu gelmesi i�in yaz�ld�.
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

        // Packs ve Lessons verilerini bekleyerek al�yoruz.
        var packs = await packsTask;
        var lessons = await lessonsTask;
        if (id == null)
        {
            // E�er id null ise, bo� bir GetByIdGroupResponse d�nd�r�yoruz.
            return new GetByIdGroupResponse
            {
                Lessons = lessons,
                Packs = packs
            };
        }

        // Packs ve Lessons verilerini paralel olarak al�yoruz.
        

        // Query sorgusunu veritaban�na yap�yoruz ve sonu�lar� al�yoruz.
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

        // Query null olabilir, bu nedenle null kontrol� yaparak varsay�lan de�eri d�nd�r�yoruz.
        return query ?? new GetByIdGroupResponse
        {
            Lessons = lessons,
            Packs = packs
        };
    }
}