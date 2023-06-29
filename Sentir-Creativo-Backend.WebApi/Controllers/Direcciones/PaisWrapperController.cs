using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Controllers.Paises;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.ViewModels.Paises;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Direcciones;

[Authorize]
[ApiController]
[Route("api/v1/paises")]
public class PaisWrapperController : ControllerBase
{
    private readonly ISelectPaisController _selectPaisController;
    
    public PaisWrapperController(ISelectPaisController selectPaisController)
    {
        _selectPaisController = selectPaisController;
    }
    
    [HttpGet("select")]
    [ProducesResponseType(typeof(SelectPaisViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectPaisViewModel>>> SelectPais() 
        => Ok(await _selectPaisController.Handle());
}