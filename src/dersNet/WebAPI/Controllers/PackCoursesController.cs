using Application.Features.PackCourses.Commands.Create;
using Application.Features.PackCourses.Commands.Delete;
using Application.Features.PackCourses.Commands.Update;
using Application.Features.PackCourses.Queries.GetById;
using Application.Features.PackCourses.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PackCoursesController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreatePackCourseCommand createPackCourseCommand)
    {
        CreatedPackCourseResponse response = await Mediator.Send(createPackCourseCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdatePackCourseCommand updatePackCourseCommand)
    {
        UpdatedPackCourseResponse response = await Mediator.Send(updatePackCourseCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedPackCourseResponse response = await Mediator.Send(new DeletePackCourseCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdPackCourseResponse response = await Mediator.Send(new GetByIdPackCourseQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListPackCourseQuery getListPackCourseQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListPackCourseListItemDto> response = await Mediator.Send(getListPackCourseQuery);
        return Ok(response);
    }
}