using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.Contracts.Controllers.Ciudades;
using Sentir_Creativo_Backend.Direcciones.BusinessObjects.ViewModels.Ciudades;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Direcciones;

[ApiController]
[Route("api/v1/ciudades")]
public class CiudadWrapperController : ControllerBase
{
    private readonly ISelectCiudadController _selectCiudadController;
    
    public CiudadWrapperController(ISelectCiudadController selectCiudadController)
    {
        _selectCiudadController = selectCiudadController;
    }
    
    [HttpGet("select")]
    [ProducesResponseType(typeof(SelectCiudadViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectCiudadViewModel>>> SelectCiudad() 
        => Ok(await _selectCiudadController.Handle());
}