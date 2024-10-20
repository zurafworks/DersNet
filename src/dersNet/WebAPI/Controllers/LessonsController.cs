using Application.Features.Lessons.Commands.Create;
using Application.Features.Lessons.Commands.Delete;
using Application.Features.Lessons.Commands.Update;
using Application.Features.Lessons.Queries.GetById;
using Application.Features.Lessons.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;
using Application.Features.Lessons.Queries.GetListWithParent;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LessonsController : BaseController
{
    [HttpPost("Add")]
    public async Task<IActionResult> Add([FromBody] CreateLessonCommand createLessonCommand)
    {
        CreatedLessonResponse response = await Mediator.Send(createLessonCommand);

        return Created(uri: "", response);
    }

    [HttpPost("Update")]
    public async Task<IActionResult> Update([FromBody] UpdateLessonCommand updateLessonCommand)
    {
        UpdatedLessonResponse response = await Mediator.Send(updateLessonCommand);

        return Ok(response);
    }

    [HttpPost("Delete")]
    public async Task<IActionResult> Delete([FromBody] Guid id)
    {
        DeletedLessonResponse response = await Mediator.Send(new DeleteLessonCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdLessonResponse response = await Mediator.Send(new GetByIdLessonQuery { Id = id });
        return Ok(response);
    }

    [HttpPost("GetList")]
    public async Task<IActionResult> GetList([FromBody] PageRequest pageRequest)
    {
        GetListLessonQuery getListLessonQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListLessonListItemDto> response = await Mediator.Send(getListLessonQuery);
        return Ok(response);
    }
    //[Route("/GetListLessonWithParent")]
    [HttpPost("GetListWithParent")]
    public async Task<IActionResult> GetListWithParent([FromBody] PageRequest pageRequest)
    {
        GetListWithParentQuery getListLessonWithParentQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListWithParentItemDto> response = await Mediator.Send(getListLessonWithParentQuery);
        return Ok(response);
    }
}
