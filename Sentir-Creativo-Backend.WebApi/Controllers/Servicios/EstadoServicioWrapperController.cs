using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.EstadoServicios;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Dtos.EstadosServicios;
using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.EstadoServicios;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Servicios;

[Authorize]
[ApiController]
[Route("api/v1/[controller]")]
public class EstadoServicioWrapperController : ControllerBase
{
    private readonly ISelectEstadoServicioController _selectEstadoServicioController;
    private readonly ICreateEstadoServicioController _createEstadoServicioController;
    private readonly IUpdateEstadoServicioController _updateEstadoServicioController;
    
    public EstadoServicioWrapperController(
        ISelectEstadoServicioController selectEstadoServicioController,
        ICreateEstadoServicioController createEstadoServicioController,
        IUpdateEstadoServicioController updateEstadoServicioController)
    {
        _selectEstadoServicioController = selectEstadoServicioController;
        _createEstadoServicioController = createEstadoServicioController;
        _updateEstadoServicioController = updateEstadoServicioController;
    }

    [HttpGet]
    [Route("/select-estado-servicio")] 
    [ProducesResponseType(typeof(SelectEstadoServicioViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectEstadoServicioViewModel>>> SelectEstadoServicio()
        => Ok(await _selectEstadoServicioController.Handle());

    [HttpPost]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateEstadoServicio([FromBody] CreateEstadoServicioDto dto)
      => Ok(await _createEstadoServicioController.Handle(dto));

    [HttpPut]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> UpdateEstadoServicio([FromBody] UpdateEstadoServicioDto dto)
    => Ok(await _updateEstadoServicioController.Handle(dto));
}