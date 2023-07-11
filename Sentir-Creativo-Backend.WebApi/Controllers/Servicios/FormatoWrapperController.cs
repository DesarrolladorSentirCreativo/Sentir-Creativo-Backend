using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.Formatos;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Dtos.Formatos;
using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.Formatos;
using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.TecnicaArtistica;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Servicios;

[Authorize]
[ApiController]
[Route("api/v1/formatos")]
public class FormatoWrapperController : ControllerBase
{
    private readonly ISelectFormatoController _selectFormatoController;
    private readonly ICreateFormatoController _createFormatoController;
    private readonly IUpdateFormatoController _updateFormatoController;
    private readonly IDeleteFormatoController _deleteFormatoController;
    private readonly IGetAllFormatoController _getAllFormatoController;
    private readonly IGetByIdFormatoController _getByIdFormatoController;
    
    public FormatoWrapperController(
        ISelectFormatoController selectFormatoController,
        ICreateFormatoController createFormatoController,
        IUpdateFormatoController updateFormatoController,
        IDeleteFormatoController deleteFormatoController,
        IGetAllFormatoController getAllFormatoController,
        IGetByIdFormatoController getByIdFormatoController)
    {
        _selectFormatoController = selectFormatoController;
        _createFormatoController = createFormatoController;
        _updateFormatoController = updateFormatoController;
        _deleteFormatoController = deleteFormatoController;
        _getAllFormatoController = getAllFormatoController;
        _getByIdFormatoController = getByIdFormatoController;
    }
    
    [HttpGet("/select")]
    [ProducesResponseType(typeof(SelectFormatoViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectFormatoViewModel>>> SelectFormato() 
        => Ok(await _selectFormatoController.Handle());

    [HttpPost]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateFormato([FromBody] CreateFormatoDto dto)
     => Ok(await _createFormatoController.Handle(dto));


    [HttpPut]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> UpdateFormato([FromBody] UpdateFormatoDto dto)
        => Ok(await _updateFormatoController.Handle(dto));

    [HttpPut("{id}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> DeleteFormato(int id)
           => Ok(await _deleteFormatoController.Handle(id));

    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<GetAllFormatoViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<GetAllFormatoViewModel>>> GetAllFormato()
        => Ok(await _getAllFormatoController.Handle());


    [HttpGet("{id}")]
    [ProducesResponseType(typeof(GetByIdFormatoViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<GetByIdFormatoViewModel>> GetByIdOcacion(int id)
   => Ok(await _getByIdFormatoController.Handle(id));

}

