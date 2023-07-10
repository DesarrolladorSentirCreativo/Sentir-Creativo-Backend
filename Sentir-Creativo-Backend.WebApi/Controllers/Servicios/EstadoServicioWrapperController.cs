using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.EstadoServicios;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Dtos.EstadosServicios;
using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.EstadoServicios;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Servicios;

[Authorize]
[ApiController]
[Route("api/v1/estados-servicios")]
public class EstadoServicioWrapperController : ControllerBase
{
    private readonly ISelectEstadoServicioController _selectEstadoServicioController;
    private readonly ICreateEstadoServicioController _createEstadoServicioController;
    private readonly IUpdateEstadoServicioController _updateEstadoServicioController;
    private readonly IDeleteEstadoServicioController _deleteEstadoServicioController;
    private readonly IGetAllEstadoServicioController _getAllEstadoServicioController;
    private readonly IGetByIdEstadoServicioController _getByIdEstadoServicioController;
    
    public EstadoServicioWrapperController(
        ISelectEstadoServicioController selectEstadoServicioController,
        ICreateEstadoServicioController createEstadoServicioController,
        IUpdateEstadoServicioController updateEstadoServicioController,
        IDeleteEstadoServicioController deleteEstadoServicioController,
        IGetAllEstadoServicioController getAllEstadoServicioController,
        IGetByIdEstadoServicioController getByIdEstadoServicioController)
    {
        _selectEstadoServicioController = selectEstadoServicioController;
        _createEstadoServicioController = createEstadoServicioController;
        _updateEstadoServicioController = updateEstadoServicioController;
        _deleteEstadoServicioController = deleteEstadoServicioController;
        _getAllEstadoServicioController = getAllEstadoServicioController;
        _getByIdEstadoServicioController = getByIdEstadoServicioController;
    }

    [HttpGet]
    [Route("select")]
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

    [HttpPut("{id}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> DeleteEstadoServicio(int id)
           => Ok(await _deleteEstadoServicioController.Handle(id));

    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<GetAllEstadoServicioViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<GetAllEstadoServicioViewModel>>> GetAllEstadoServicio()
    => Ok(await _getAllEstadoServicioController.Handle());

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(GetByIdEstadoServicioViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<GetByIdEstadoServicioViewModel>> GetByIdEstadoServicio(int id)
     => Ok(await _getByIdEstadoServicioController.Handle(id));

}