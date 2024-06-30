using Application.Features.Sessions.Commands.Create;
using Application.Features.Sessions.Commands.Delete;
using Application.Features.Sessions.Commands.Update;
using Application.Features.Sessions.Queries.GetById;
using Application.Features.Sessions.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SessionsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateSessionCommand createSessionCommand)
    {
        CreatedSessionResponse response = await Mediator.Send(createSessionCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateSessionCommand updateSessionCommand)
    {
        UpdatedSessionResponse response = await Mediator.Send(updateSessionCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedSessionResponse response = await Mediator.Send(new DeleteSessionCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdSessionResponse response = await Mediator.Send(new GetByIdSessionQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListSessionQuery getListSessionQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListSessionListItemDto> response = await Mediator.Send(getListSessionQuery);
        return Ok(response);
    }
}