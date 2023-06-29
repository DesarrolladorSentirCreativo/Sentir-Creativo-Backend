using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Prefijos;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Prefijos;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Audiencias;

[Authorize]
[ApiController]
[Route("api/v1/prefijos")]
public class PrefijoWrapperController : ControllerBase
{
    private readonly ISelectPrefijoController _selectPrefijoController;
    
    public PrefijoWrapperController(ISelectPrefijoController selectPrefijoController)
    {
        _selectPrefijoController = selectPrefijoController;
    }
    
    [HttpGet("select")]
    [ProducesResponseType(typeof(IReadOnlyList<SelectPrefijoViewModel>), (int) HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectPrefijoViewModel>>> SelectPrefijo()
        => Ok(await _selectPrefijoController.Handle());
}