using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Audiencias.Application.Prefijos.Features.Queries.Select;
using Sentir_Creativo_Backend.Audiencias.Application.Prefijos.Features.ViewModel;

namespace Sentir_Creativo_Backend.API.Controllers.Audiencias;

[ApiController]
[Route("api/v1/[controller]")]
public class PrefijoController : ControllerBase
{
    private readonly IMediator _mediator;
    
    public PrefijoController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet("select")]
    [ProducesResponseType(typeof(IReadOnlyList<SelectPrefijoViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectPrefijoViewModel>>> GetPaginationVideo()
    { 
        var prefijos = await _mediator.Send(new SelectPrefijoQuery());
        return Ok(prefijos);
    }
}