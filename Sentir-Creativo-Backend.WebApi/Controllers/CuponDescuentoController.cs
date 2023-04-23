using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;
using Sentir_Creativo_Backend.CuponesDescuentos.BusinessObject.Controllers;
using Sentir_Creativo_Backend.CuponesDescuentos.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.WebApi.Controllers;

[ApiController]
[Route("api/v1/cupones-descuentos")]
public class CuponDescuentoController : ControllerBase
{
    private readonly ISelectCuponDescuentoController _selectCuponDescuentoController;
    
    public CuponDescuentoController(ISelectCuponDescuentoController selectCuponDescuentoController)
    {
        _selectCuponDescuentoController = selectCuponDescuentoController;
    }
    
    [HttpGet("select")]
    [ProducesResponseType(typeof(SelectCuponDescuentoViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<CuponDescuentoViewModel>>> SelectCuponDescuento() 
        => Ok(await _selectCuponDescuentoController.Handle());
}