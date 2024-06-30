using Application.Features.GroupUsers.Commands.Create;
using Application.Features.GroupUsers.Commands.Delete;
using Application.Features.GroupUsers.Commands.Update;
using Application.Features.GroupUsers.Queries.GetById;
using Application.Features.GroupUsers.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GroupUsersController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateGroupUserCommand createGroupUserCommand)
    {
        CreatedGroupUserResponse response = await Mediator.Send(createGroupUserCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateGroupUserCommand updateGroupUserCommand)
    {
        UpdatedGroupUserResponse response = await Mediator.Send(updateGroupUserCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedGroupUserResponse response = await Mediator.Send(new DeleteGroupUserCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdGroupUserResponse response = await Mediator.Send(new GetByIdGroupUserQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListGroupUserQuery getListGroupUserQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListGroupUserListItemDto> response = await Mediator.Send(getListGroupUserQuery);
        return Ok(response);
    }
}