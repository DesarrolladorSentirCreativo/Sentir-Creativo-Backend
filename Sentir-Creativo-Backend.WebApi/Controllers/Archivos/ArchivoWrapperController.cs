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
    private readonly IUpdateArchivoController _updateArchivoController;
    
    public ArchivoWrapperController(
        ICreateArchivoController createArchivoController,
        IUpdateArchivoController updateArchivoController)
    {
        _createArchivoController = createArchivoController;
        _updateArchivoController = updateArchivoController;
    }
    
    [HttpPost(Name = "CreateArchivo")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateArchivo([FromBody] CreateArchivoDto dto)
        => Ok(await _createArchivoController.Handle(dto));
    
    [HttpPut(Name = "UpdateArchivo")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> UpdateArchivo([FromBody] UpdateArchivoDto dto)
        => Ok(await _updateArchivoController.Handle(dto));
    
}