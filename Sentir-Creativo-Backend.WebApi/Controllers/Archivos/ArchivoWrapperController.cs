using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Controllers.Archivos;
using Sentir_Creativo_Backend.Archivos.BusinessObject.DTO;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Archivos;

[ApiController]
[Route("api/v1/archivos")]
public class ArchivoWrapperController : ControllerBase
{
    private readonly ICreateArchivoController _createArchivoController;
    
    public ArchivoWrapperController(ICreateArchivoController createArchivoController)
    {
        _createArchivoController = createArchivoController;
    }
    
    [HttpPost(Name = "CreateArchivo")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateArchivo([FromBody] CreateArchivoDto dto)
        => Ok(await _createArchivoController.Handle(dto));
    
}