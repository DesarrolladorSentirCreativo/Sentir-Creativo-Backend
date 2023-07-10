using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.Formatos;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Dtos.Formatos;
using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.Formatos;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Servicios;

[Authorize]
[ApiController]
[Route("api/v1/formatos")]
public class FormatoWrapperController : ControllerBase
{
    private readonly ISelectFormatoController _selectFormatoController;
    private readonly ICreateFormatoController _createFormatoController;
    
    public FormatoWrapperController(
        ISelectFormatoController selectFormatoController,
        ICreateFormatoController createFormatoController)
    {
        _selectFormatoController = selectFormatoController;
        _createFormatoController = createFormatoController;
    }
    
    [HttpGet("/select-formatos")]
    [ProducesResponseType(typeof(SelectFormatoViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectFormatoViewModel>>> SelectFormato() 
        => Ok(await _selectFormatoController.Handle());

    [HttpPost]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateFormato([FromBody] CreateFormatoDto dto)
     => Ok(await _createFormatoController.Handle(dto));

}

