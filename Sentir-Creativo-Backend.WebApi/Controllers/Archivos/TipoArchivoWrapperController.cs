using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Controllers.TipoArchivos;
using Sentir_Creativo_Backend.Archivos.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Archivos;

[Authorize]
[ApiController]
[Route("api/v1/tipos-archivos")]
public class TipoArchivoWrapperController : ControllerBase
{
    private readonly ISelectTipoArchivoController _selectTipoArchivoController;
    
    public TipoArchivoWrapperController(
        ISelectTipoArchivoController selectTipoArchivoController
        )
    {
        _selectTipoArchivoController = selectTipoArchivoController;
    }
    
    [HttpGet("select")]
    [ProducesResponseType(typeof(IReadOnlyList<SelectTipoArchivoViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectTipoArchivoViewModel>>> SelectTipoArchivo()
        => Ok(await _selectTipoArchivoController.Handle());
}