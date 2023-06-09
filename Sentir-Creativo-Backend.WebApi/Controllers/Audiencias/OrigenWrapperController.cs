using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Origenes;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Audiencias;

[Authorize]
[ApiController]
[Route("api/v1/origenes")]
public class OrigenWrapperController : ControllerBase
{
    private readonly ISelectOrigenController _selectOrigenController;
    
    public OrigenWrapperController(ISelectOrigenController selectOrigenController)
    {
        _selectOrigenController = selectOrigenController;
    }
    
    [HttpGet("select")]
    [ProducesResponseType(typeof(SelectOrigenViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectOrigenViewModel>>> SelectOrigen()
        =>Ok(await _selectOrigenController.Handle()); 
}
