using Application.Features.Packs.Commands.Create;
using Application.Features.Packs.Commands.Delete;
using Application.Features.Packs.Commands.Update;
using Application.Features.Packs.Queries.GetById;
using Application.Features.Packs.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;
using Application.Features.Packs.Queries.GetListByFilter;
using WebAPI.Controllers.Dtos;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PacksController : BaseController
{
    [HttpPost("Add")]
    public async Task<IActionResult> Add([FromBody] CreatePackCommand createPackCommand)
    {
        CreatedPackResponse response = await Mediator.Send(createPackCommand);

        return Created(uri: "", response);
    }
    [HttpPost("Update")]
    public async Task<IActionResult> Update([FromBody] UpdatePackCommand updatePackCommand)
    {
        UpdatedPackResponse response = await Mediator.Send(updatePackCommand);

        return Ok(response);
    }
    [HttpPost("Delete")]
    public async Task<IActionResult> Delete([FromBody] GetByIdRequestDto request)
    {
        DeletedPackResponse response = await Mediator.Send(new DeletePackCommand { Id = request.id});

        return Ok(response);
    }
    [HttpPost("Get")]
    public async Task<IActionResult> GetById([FromBody] GetByIdRequestDto request)
    {
        GetByIdPackResponse response = await Mediator.Send(new GetByIdPackQuery { Id = request.id });
        return Ok(response);
    }
    [HttpPost("GetList")]
    public async Task<IActionResult> GetList([FromBody] PageRequest pageRequest)
    {
        GetListPackQuery getListPackQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListPackListItemDto> response = await Mediator.Send(getListPackQuery);
        return Ok(response);
    }

    [HttpPost("GetListByFilter")]
    public async Task<IActionResult> GetListByFilter([FromBody] GetListByFilterQueryDto request)
    {
        GetListPackByFilterQuery getListPackQuery = new() { Request = request };
        GetListResponse<GetListPackListItemDto> response = await Mediator.Send(getListPackQuery);
        return Ok(response);
    }
}