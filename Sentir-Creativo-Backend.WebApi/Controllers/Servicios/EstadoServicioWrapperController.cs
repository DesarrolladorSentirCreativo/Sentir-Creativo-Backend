using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.EstadoServicios;
using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.EstadoServicios;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Servicios;

[Authorize]
[ApiController]
[Route("api/v1/[controller]")]
public class EstadoServicioWrapperController : ControllerBase
{
    private readonly ISelectEstadoServicioController _selectEstadoServicioController;
    
    public EstadoServicioWrapperController(ISelectEstadoServicioController selectEstadoServicioController)
    {
        _selectEstadoServicioController = selectEstadoServicioController;
    }

    [HttpGet]
    [Route("/select-estado-servicio")] 
    [ProducesResponseType(typeof(SelectEstadoServicioViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectEstadoServicioViewModel>>> SelectEstadoServicio()
        => Ok(await _selectEstadoServicioController.Handle());
}