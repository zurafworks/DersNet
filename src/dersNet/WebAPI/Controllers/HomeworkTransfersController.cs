using Application.Features.HomeworkTransfers.Commands.Create;
using Application.Features.HomeworkTransfers.Commands.Delete;
using Application.Features.HomeworkTransfers.Commands.Update;
using Application.Features.HomeworkTransfers.Queries.GetById;
using Application.Features.HomeworkTransfers.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HomeworkTransfersController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateHomeworkTransferCommand createHomeworkTransferCommand)
    {
        CreatedHomeworkTransferResponse response = await Mediator.Send(createHomeworkTransferCommand);

        return Created(uri: "", response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateHomeworkTransferCommand updateHomeworkTransferCommand)
    {
        UpdatedHomeworkTransferResponse response = await Mediator.Send(updateHomeworkTransferCommand);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        DeletedHomeworkTransferResponse response = await Mediator.Send(new DeleteHomeworkTransferCommand { Id = id });

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        GetByIdHomeworkTransferResponse response = await Mediator.Send(new GetByIdHomeworkTransferQuery { Id = id });
        return Ok(response);
    }

    [HttpGet]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListHomeworkTransferQuery getListHomeworkTransferQuery = new() { PageRequest = pageRequest };
        GetListResponse<GetListHomeworkTransferListItemDto> response = await Mediator.Send(getListHomeworkTransferQuery);
        return Ok(response);
    }
}