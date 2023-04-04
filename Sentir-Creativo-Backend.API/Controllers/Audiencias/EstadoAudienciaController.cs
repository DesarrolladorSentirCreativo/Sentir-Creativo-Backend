using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Audiencias.Application.EstadosAudiencias.Features.Queries.Select;
using Sentir_Creativo_Backend.Audiencias.Application.EstadosAudiencias.Features.ViewModels;

namespace Sentir_Creativo_Backend.API.Controllers.Audiencias;

[ApiController]
[Route("api/v1/[controller]")]
public class EstadoAudienciaController : ControllerBase
{
    private readonly IMediator _mediator;
    
    public EstadoAudienciaController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet("select")]
    [ProducesResponseType(typeof(IReadOnlyList<SelectEstadoAudienciaViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectEstadoAudienciaViewModel>>> GetPaginationVideo()
    { 
        var estadoAudiencias = await _mediator.Send(new SelectEstadoAudienciaQuery());
        return Ok(estadoAudiencias);
    }
}