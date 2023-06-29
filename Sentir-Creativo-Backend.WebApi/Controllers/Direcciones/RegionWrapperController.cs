using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Controllers.Regiones;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.ViewModels.Regiones;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Direcciones;

[Authorize]
[ApiController]
[Route("api/v1/regiones")]
public class RegionWrapperController : ControllerBase
{
    private readonly ISelectRegionController _selectRegionController;
    
    public RegionWrapperController(ISelectRegionController selectRegionController)
    {
        _selectRegionController = selectRegionController;
    }
    
    [HttpGet("select")]
    [ProducesResponseType(typeof(SelectRegionViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectRegionViewModel>>> SelectRegion() 
        => Ok(await _selectRegionController.Handle());
}