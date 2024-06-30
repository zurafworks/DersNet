using Application.Features.Homework.Commands.Create;
using Application.Features.Homework.Commands.Delete;
using Application.Features.Homework.Commands.Update;
using Application.Features.Homework.Queries.GetById;
using Application.Features.Homework.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HomeworkController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateHomeworkCommand createHomeworkCommand)
    {
        CreatedHomeworkResponse response = await Mediator.Send(createHomeworkCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateHomeworkCommand updateHomeworkCommand)
    {
        UpdatedHomeworkResponse response = await Mediator.Send(updateHomeworkCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedHomeworkResponse response = await Mediator.Send(new DeleteHomeworkCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdHomeworkResponse response = await Mediator.Send(new GetByIdHomeworkQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListHomeworkQuery getListHomeworkQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListHomeworkListItemDto> response = await Mediator.Send(getListHomeworkQuery);
        return Ok(response);
    }
}