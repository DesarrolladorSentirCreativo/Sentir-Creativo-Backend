using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Audiencias.Application.Origenes.Features.Queries.Select;
using Sentir_Creativo_Backend.Audiencias.Application.Origenes.Features.ViewModels;

namespace Sentir_Creativo_Backend.API.Controllers.Audiencias;

[ApiController]
[Route("api/v1/[controller]")]
public class OrigenController : ControllerBase
{
    private readonly IMediator _mediator;
    
    public OrigenController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet("select")]
    [ProducesResponseType(typeof(IReadOnlyList<SelectOrigenViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectOrigenViewModel>>> GetPaginationVideo()
    { 
        var origenes = await _mediator.Send(new SelectOrigenQuery());
        return Ok(origenes);
    }
    
}