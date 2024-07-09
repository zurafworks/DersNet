using Application.Features.Packs.Commands.Create;
using Application.Features.Packs.Commands.Delete;
using Application.Features.Packs.Commands.Update;
using Application.Features.Packs.Queries.GetById;
using Application.Features.Packs.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PacksController : BaseController
{
    [Route("/add-packs")]
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreatePackCommand createPackCommand)
    {
        CreatedPackResponse response = await Mediator.Send(createPackCommand);

        return Created(uri: "", response);
    }

    [Route("/update-packs")]
    [HttpPost]
    public async Task<IActionResult> Update([FromBody] UpdatePackCommand updatePackCommand)
    {
        UpdatedPackResponse response = await Mediator.Send(updatePackCommand);

        return Ok(response);
    }

    [Route("/delete-packs")]
    [HttpPost]
    public async Task<IActionResult> Delete([FromBody] Guid id)
    {
        DeletedPackResponse response = await Mediator.Send(new DeletePackCommand { Id = id });

        return Ok(response);
    }
    [Route("/getbyid-packs/{id}")]
    [HttpPost]
    public async Task<IActionResult> GetById([FromBody] Guid id)
    {
        GetByIdPackResponse response = await Mediator.Send(new GetByIdPackQuery { Id = id });
        return Ok(response);
    }
    [Route("/getlist-packs")]
    [HttpPost]
    public async Task<IActionResult> GetList([FromBody] PageRequest pageRequest)
    {
        GetListPackQuery getListPackQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListPackListItemDto> response = await Mediator.Send(getListPackQuery);
        return Ok(response);
    }
}