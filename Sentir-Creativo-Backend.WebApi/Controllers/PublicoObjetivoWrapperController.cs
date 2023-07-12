using Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Controllers.PublicoObjetivos;
using Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Dtos;
using Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.ViewModels;
using Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.ViewModels.PublicoObjetivos;
using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.TecnicaArtistica;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Privilegios;

namespace Sentir_Creativo_Backend.WebApi.Controllers;

[Authorize]
[ApiController]
[Route("api/v1/publicos-objetivos")]
public class PublicoObjetivoWrapperController : ControllerBase
{
    private readonly ISelectPublicoObjetivoController _selectPublicoObjetivoController;
    private readonly ICreatePublicoObjetivoController _createPublicoObjetivoController;
    private readonly IUpdatePublicoObjetivoController _updatePublicoObjetivoController;
    private readonly IDeletePublicoObjetivoController _deletePublicoObjetivoController;
    private readonly IGetAllPublicoObjetivoController _getAllPublicoObjetivoController;
    private readonly IGetByIdPublicoObjetivoController _getByIdPublicoObjetivoController;
    
    public PublicoObjetivoWrapperController(
        ISelectPublicoObjetivoController selectPublicoObjetivoController,
        ICreatePublicoObjetivoController createPublicoObjetivoController,
        IUpdatePublicoObjetivoController updatePublicoObjetivoController,
        IDeletePublicoObjetivoController deletePublicoObjetivoController,
        IGetAllPublicoObjetivoController getAllPublicoObjetivoController,
        IGetByIdPublicoObjetivoController getByIdPublicoObjetivoController)
    {
        _selectPublicoObjetivoController = selectPublicoObjetivoController;
        _createPublicoObjetivoController = createPublicoObjetivoController;
        _updatePublicoObjetivoController = updatePublicoObjetivoController;
        _deletePublicoObjetivoController = deletePublicoObjetivoController;
        _getAllPublicoObjetivoController = getAllPublicoObjetivoController;
        _getByIdPublicoObjetivoController = getByIdPublicoObjetivoController;
    }

    [HttpPost]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreatePublicoObjetivo([FromBody] CreatePublicoObjetivoDto dto)
        => Ok(await _createPublicoObjetivoController.Handle(dto));

    [HttpPut]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> UpdatePublicoObjetivo([FromBody] UpdatePublicoObjetivoDto dto)
           => Ok(await _updatePublicoObjetivoController.Handle(dto));


    [HttpPut("{id}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> DeletePublicoObjetivo(int id)
        => Ok(await _deletePublicoObjetivoController.Handle(id));

    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<GetAllPublicoObjetivoViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<GetAllPublicoObjetivoViewModel>>> GetAllPublicoObjetivo()
        => Ok(await _getAllPublicoObjetivoController.Handle());

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(GetByIdPublicoObjetivoViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<GetByIdPublicoObjetivoViewModel>> GetByIdPublicoObjetivo(int id)
   => Ok(await _getByIdPublicoObjetivoController.Handle(id));


    [HttpGet]
    [Route("/select-publico-objetivo")] 
    [ProducesResponseType(typeof(SelectPublicoObjetivoViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectPublicoObjetivoViewModel>>> SelectPublicoObjetivo() 
        => Ok(await _selectPublicoObjetivoController.Handle());
}