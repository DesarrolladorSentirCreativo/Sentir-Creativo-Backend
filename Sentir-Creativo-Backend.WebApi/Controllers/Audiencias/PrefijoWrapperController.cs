using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Prefijos;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Prefijos;
using Sentir_Creativo_Backend.Audiencias.Controllers.Prefijos;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Audiencias;

[ApiController]
[Route("api/v1/prefijos")]
public class PrefijoWrapperController : ControllerBase
{
    private readonly ISelectPrefijoController _selectPrefijoController;
    
    public PrefijoWrapperController(ISelectPrefijoController selectPrefijoController)
    {
        _selectPrefijoController = selectPrefijoController;
    }
    
    [HttpGet]
    [Route("/select-prefijos")] 
    [ProducesResponseType(typeof(IReadOnlyList<SelectPrefijoViewModel>), (int) HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectPrefijoViewModel>>> SelectPrefijo()
        => Ok(await _selectPrefijoController.Handle());
}