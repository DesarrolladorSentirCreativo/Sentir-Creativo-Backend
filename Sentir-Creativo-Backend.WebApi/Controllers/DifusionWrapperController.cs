using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Difusiones.BusinessObject.Controllers;
using Sentir_Creativo_Backend.Difusiones.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.WebApi.Controllers;

[Authorize]
[ApiController]
[Route("api/v1/difusiones")]
public class DifusionWrapperController : ControllerBase
{
    private readonly ISelectDifusionController _selectDifusionController;
    
    public DifusionWrapperController(ISelectDifusionController selectDifusionController)
    {
        _selectDifusionController = selectDifusionController;
    }
    
    [HttpGet("select")]
    [ProducesResponseType(typeof(SelectDifusionViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectDifusionViewModel>>> SelectDifusion() 
        => Ok(await _selectDifusionController.Handle());
}