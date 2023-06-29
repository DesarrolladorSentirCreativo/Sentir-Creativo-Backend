using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Bitacoras.BusinessObjects.Controllers.Bitacoras;
using Sentir_Creativo_Backend.Bitacoras.BusinessObjects.DTO;

namespace Sentir_Creativo_Backend.WebApi.Controllers;

[Authorize]
[ApiController]
[Route("api/v1/bitacoras")]
public class BitacoraWrapperController : ControllerBase
{
    private readonly ICreateBitacoraController _createBitacoraController;
    
    public BitacoraWrapperController(ICreateBitacoraController createBitacoraController)
    {
        _createBitacoraController = createBitacoraController;
    }
    
    [HttpPost(Name = "CreateBitacora")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateBitacora([FromBody] CreateBitacoraDto dto)
        => Ok(await _createBitacoraController.Handle(dto));
}