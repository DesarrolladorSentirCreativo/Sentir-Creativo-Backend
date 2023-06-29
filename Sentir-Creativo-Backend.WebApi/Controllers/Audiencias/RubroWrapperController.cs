using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Rubros;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Rubros;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Audiencias;

[Authorize]
[ApiController]
[Route("api/v1/rubros")]
public class RubroWrapperController : ControllerBase
{
    private readonly ISelectRubroController _selectRubroController;
    
    public RubroWrapperController(ISelectRubroController selectRubroController)
    {
        _selectRubroController = selectRubroController;
    }
    
    [HttpGet("select")]
    [ProducesResponseType(typeof(IReadOnlyList<SelectRubroViewModel>), (int) HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectRubroViewModel>>> SelectRubro()
        => Ok(await _selectRubroController.Handle());
}