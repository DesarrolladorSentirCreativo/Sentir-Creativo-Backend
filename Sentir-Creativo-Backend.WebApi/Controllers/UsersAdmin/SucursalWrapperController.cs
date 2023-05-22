using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Sucursales;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Sucursales;

namespace Sentir_Creativo_Backend.WebApi.Controllers.UsersAdmin;

[ApiController]
[Route("api/v1/sucursales")]
public class SucursalWrapperController : ControllerBase
{
    private readonly ICreateSucursalController _createSucursalController;
    
    public SucursalWrapperController(ICreateSucursalController createSucursalController)
    {
        _createSucursalController = createSucursalController;
    }
    
    [HttpPost(Name = "CreateSucursal")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateAudiencia([FromBody] CreateSucursalDto dto)
        => Ok(await _createSucursalController.Handle(dto));
}