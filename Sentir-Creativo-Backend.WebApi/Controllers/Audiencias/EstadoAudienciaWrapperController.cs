using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.EstadoAudiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.EstadoAudiencias;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Audiencias;

[Authorize]
[ApiController]
[Route("api/v1/estados-audiencias")]
public class EstadoAudienciaWrapperController : ControllerBase
{
    private readonly ISelectEstadoAudienciaController _selectEstadoAudienciaController;
    
    public EstadoAudienciaWrapperController(ISelectEstadoAudienciaController selectEstadoAudienciaController)
    {
        _selectEstadoAudienciaController = selectEstadoAudienciaController;
    }
    
    [HttpGet("select")]
    [ProducesResponseType(typeof(SelectEstadoAudienciaViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectEstadoAudienciaViewModel>>> SelectEstadoAudiencias()
        => Ok(await _selectEstadoAudienciaController.Handle()); 
    
}