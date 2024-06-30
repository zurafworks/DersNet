using Application.Features.Groups.Commands.Create;
using Application.Features.Groups.Commands.Delete;
using Application.Features.Groups.Commands.Update;
using Application.Features.Groups.Queries.GetById;
using Application.Features.Groups.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GroupsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateGroupCommand createGroupCommand)
    {
        CreatedGroupResponse response = await Mediator.Send(createGroupCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateGroupCommand updateGroupCommand)
    {
        UpdatedGroupResponse response = await Mediator.Send(updateGroupCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedGroupResponse response = await Mediator.Send(new DeleteGroupCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdGroupResponse response = await Mediator.Send(new GetByIdGroupQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListGroupQuery getListGroupQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListGroupListItemDto> response = await Mediator.Send(getListGroupQuery);
        return Ok(response);
    }
}