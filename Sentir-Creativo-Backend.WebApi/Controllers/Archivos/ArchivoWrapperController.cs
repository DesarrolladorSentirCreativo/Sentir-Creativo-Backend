using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Archivos.BusinessObject.Controllers.Archivos;
using Sentir_Creativo_Backend.Archivos.BusinessObject.DTO;
using Sentir_Creativo_Backend.Archivos.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Archivos;

[ApiController]
[Route("api/v1/archivos")]
public class ArchivoWrapperController : ControllerBase
{
    private readonly ICreateArchivoController _createArchivoController;
    private readonly IUpdateArchivoController _updateArchivoController;
    private readonly IDeleteArchivoController _deleteArchivoController;
    private readonly IGetByIdArchivoController _getByIdArchivoController;
    
    public ArchivoWrapperController(
        ICreateArchivoController createArchivoController,
        IUpdateArchivoController updateArchivoController,
        IDeleteArchivoController deleteArchivoController,
        IGetByIdArchivoController getByIdArchivoController)
    {
        _createArchivoController = createArchivoController;
        _updateArchivoController = updateArchivoController;
        _deleteArchivoController = deleteArchivoController;
        _getByIdArchivoController = getByIdArchivoController;
    }
    
    [HttpPost(Name = "CreateArchivo")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateArchivo([FromBody] CreateArchivoDto dto)
        => Ok(await _createArchivoController.Handle(dto));
    
    [HttpPut(Name = "UpdateArchivo")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> UpdateArchivo([FromBody] UpdateArchivoDto dto)
        => Ok(await _updateArchivoController.Handle(dto));
    
    [HttpDelete("{id}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> DeleteArchivo(int id)
        => Ok(await _deleteArchivoController.Handle(id));
    
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(GetByIdArchivoViewModel),(int)HttpStatusCode.OK)]
    public async Task<ActionResult<GetByIdArchivoViewModel>> GetByIdAudiencia(int id)
        =>Ok(await _getByIdArchivoController.Handle(id));

}