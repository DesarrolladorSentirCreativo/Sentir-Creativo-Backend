using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Audiencias.Application.Audiencias.Features.Queries.Paginator;
using Sentir_Creativo_Backend.Audiencias.Application.Audiencias.Features.ViewModel;
using Sentir_Creativo_Backend.SharedKernel.Application.Features.ViewModels;

namespace Sentir_Creativo_Backend.API.Controllers.Audiencias;

[ApiController]
[Route("api/v1/[controller]")]
public class AudienciaController : ControllerBase
{
    private readonly IMediator _mediator;
    
    public AudienciaController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet]
    [ProducesResponseType(typeof(PaginationViewModel<AudienciaViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<PaginationViewModel<AudienciaViewModel>>> GetPaginationVideo(
        [FromQuery] PaginationAudienciaQuery paginationAudienciaParams
    )
    { 
        var paginationAudiencia = await _mediator.Send(paginationAudienciaParams);
        return Ok(paginationAudiencia);
    }

}