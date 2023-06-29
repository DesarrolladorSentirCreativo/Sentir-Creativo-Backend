using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Controllers.EstadoProyectos;
using Sentir_Creativo_Backend.Proyectos.BusinessObject.ViewModels.EstadoProyectos;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Proyectos;

[Authorize]
[ApiController]
[Route("api/v1/estados-proyectos")]
public class EstadoProyectoWrapperController : ControllerBase
{
    private readonly ISelectEstadoProyectoController _selectEstadoProyectoController;
    
    public EstadoProyectoWrapperController(ISelectEstadoProyectoController selectEstadoProyectoController)
    {
        _selectEstadoProyectoController = selectEstadoProyectoController;
    }
    
    [HttpGet("select")]
    [ProducesResponseType(typeof(SelectEstadoProyectoViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectEstadoProyectoViewModel>>> SelectEstadoProyecto() 
        => Ok(await _selectEstadoProyectoController.Handle());
}