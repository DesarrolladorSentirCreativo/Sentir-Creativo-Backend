using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Audiencias.Application.Cercanias.Features.Queries.Select;
using Sentir_Creativo_Backend.Audiencias.Application.Cercanias.Features.ViewModels;

namespace Sentir_Creativo_Backend.API.Controllers.Audiencias;

[ApiController]
[Route("api/v1/[controller]")]
public class CercaniaController : ControllerBase
{
    private readonly IMediator _mediator;
    
    public CercaniaController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet("select")]
    [ProducesResponseType(typeof(IReadOnlyList<SelectCercaniaViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectCercaniaViewModel>>> GetPaginationVideo()
    { 
        var cercanias = await _mediator.Send(new SelectCercaniaQuery());
        return Ok(cercanias);
    }
}