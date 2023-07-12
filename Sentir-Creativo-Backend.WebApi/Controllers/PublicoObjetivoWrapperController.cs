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
    
    public PublicoObjetivoWrapperController(
        ISelectPublicoObjetivoController selectPublicoObjetivoController,
        ICreatePublicoObjetivoController createPublicoObjetivoController)
    {
        _selectPublicoObjetivoController = selectPublicoObjetivoController;
        _createPublicoObjetivoController = createPublicoObjetivoController;
    }

    [HttpPost]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreatePublicoObjetivo([FromBody] CreatePublicoObjetivoDto dto)
        => Ok(await _createPublicoObjetivoController.Handle(dto));

    [HttpGet]
    [Route("/select-publico-objetivo")] 
    [ProducesResponseType(typeof(SelectPublicoObjetivoViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectPublicoObjetivoViewModel>>> SelectPublicoObjetivo() 
        => Ok(await _selectPublicoObjetivoController.Handle());
}