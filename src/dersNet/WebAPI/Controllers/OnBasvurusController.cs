using Application.Features.OnBasvurus.Commands.Create;
using Application.Features.OnBasvurus.Commands.Delete;
using Application.Features.OnBasvurus.Commands.Update;
using Application.Features.OnBasvurus.Queries.GetById;
using Application.Features.OnBasvurus.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;
using Application.Features.Lessons.Queries.GetListWithParent;
using Application.Features.OnBasvurus.Queries.GetListWithStrings;
using WebAPI.Controllers.Dtos;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OnBasvurusController : BaseController
{
    [HttpPost("Add")]
    public async Task<IActionResult> Add([FromBody] CreateOnBasvuruCommand createOnBasvuruCommand)
    {
        CreatedOnBasvuruResponse response = await Mediator.Send(createOnBasvuruCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateOnBasvuruCommand updateOnBasvuruCommand)
    {
        UpdatedOnBasvuruResponse response = await Mediator.Send(updateOnBasvuruCommand);

        return Ok(response);
    }

    [HttpPost("Delete")]
    public async Task<IActionResult> Delete([FromBody] GetByIdRequestDto request)
    {
        var id = request.id;
        DeletedOnBasvuruResponse response = await Mediator.Send(new DeleteOnBasvuruCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdOnBasvuruResponse response = await Mediator.Send(new GetByIdOnBasvuruQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListOnBasvuruQuery getListOnBasvuruQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListOnBasvuruListItemDto> response = await Mediator.Send(getListOnBasvuruQuery);
        return Ok(response);
    }

    [HttpPost("GetListWithStrings")]
    public async Task<IActionResult> GetListWithStrings([FromBody] PageRequest pageRequest)
    {
        GetListOnBasvuruWithStringsQuery getListOnBasvuruWithStringsQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListOnBasvuruWithStringsListItemDto> response = await Mediator.Send(getListOnBasvuruWithStringsQuery);
        return Ok(response);
    }
}