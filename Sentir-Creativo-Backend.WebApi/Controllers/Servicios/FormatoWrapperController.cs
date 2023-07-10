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
    private readonly IUpdateFormatoController _updateFormatoController;
    private readonly IDeleteFormatoController _deleteFormatoController;
    
    public FormatoWrapperController(
        ISelectFormatoController selectFormatoController,
        ICreateFormatoController createFormatoController,
        IUpdateFormatoController updateFormatoController,
        IDeleteFormatoController deleteFormatoController)
    {
        _selectFormatoController = selectFormatoController;
        _createFormatoController = createFormatoController;
        _updateFormatoController = updateFormatoController;
        _deleteFormatoController = deleteFormatoController;
    }
    
    [HttpGet("/select-formatos")]
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

}

