using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Colecciones.BusinessObject.Contracts.Controllers.Colecciones;
using Sentir_Creativo_Backend.Colecciones.BusinessObject.ViewModels.Colecciones;

namespace Sentir_Creativo_Backend.WebApi.Controllers;

[Authorize]
[ApiController]
[Route("api/v1/colecciones")]
public class ColeccionWrapperController : ControllerBase
{
    private readonly ISelectColeccionController _selectColeccionController;
    
    public ColeccionWrapperController(ISelectColeccionController selectColeccionController)
    {
        _selectColeccionController = selectColeccionController;
    }
    
    [HttpGet]
    [Route("/select-coleccion")] 
    [ProducesResponseType(typeof(SelectColeccionViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectColeccionViewModel>>> SelectColeccion() 
        => Ok(await _selectColeccionController.Handle());
}