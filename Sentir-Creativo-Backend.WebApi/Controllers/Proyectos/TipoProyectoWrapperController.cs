using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Proyectos.BusinessObject.Contracts.Controllers.TipoProyectos;
using Sentir_Creativo_Backend.Proyectos.BusinessObject.ViewModels.TiposProyectos;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Proyectos;

[Authorize]
[ApiController]
[Route("api/v1/tipos-proyectos")]
public class TipoProyectoWrapperController : ControllerBase
{
    private readonly ISelectTipoProyectoController _selectTipoProyectoController;
    
    public TipoProyectoWrapperController(ISelectTipoProyectoController selectTipoProyectoController)
    {
        _selectTipoProyectoController = selectTipoProyectoController;
    }
    
    [HttpGet]
    [Route("/select-tipo-proyecto")] 
    [ProducesResponseType(typeof(SelectTipoProyectoViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectTipoProyectoViewModel>>> SelectTipoProyecto() 
        => Ok(await _selectTipoProyectoController.Handle());
}