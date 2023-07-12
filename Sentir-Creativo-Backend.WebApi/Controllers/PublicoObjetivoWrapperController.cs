using Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Controllers.PublicoObjetivos;
using Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Dtos;
using Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.ViewModels;

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
    
    public PublicoObjetivoWrapperController(
        ISelectPublicoObjetivoController selectPublicoObjetivoController,
        ICreatePublicoObjetivoController createPublicoObjetivoController,
        IUpdatePublicoObjetivoController updatePublicoObjetivoController,
        IDeletePublicoObjetivoController deletePublicoObjetivoController)
    {
        _selectPublicoObjetivoController = selectPublicoObjetivoController;
        _createPublicoObjetivoController = createPublicoObjetivoController;
        _updatePublicoObjetivoController = updatePublicoObjetivoController;
        _deletePublicoObjetivoController = deletePublicoObjetivoController;
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
    [Route("/select-publico-objetivo")] 
    [ProducesResponseType(typeof(SelectPublicoObjetivoViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectPublicoObjetivoViewModel>>> SelectPublicoObjetivo() 
        => Ok(await _selectPublicoObjetivoController.Handle());
}