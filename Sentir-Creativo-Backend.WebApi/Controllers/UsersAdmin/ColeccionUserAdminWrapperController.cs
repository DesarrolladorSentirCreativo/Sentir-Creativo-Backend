using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.ColeccionesUserAdmin;

namespace Sentir_Creativo_Backend.WebApi.Controllers.UsersAdmin;

[ApiController]
[Route("api/v1/colecciones-admin")]
public class ColeccionUserAdminWrapperController : ControllerBase
{
    private readonly ICreateColeccionUserAdminController _createColeccionUserAdminController;
    
    public ColeccionUserAdminWrapperController(
        ICreateColeccionUserAdminController createColeccionUserAdminController)
    {
        _createColeccionUserAdminController = createColeccionUserAdminController;
    }
    
    [HttpPost(Name = "CreateColeccionUserAdmin")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateColeccionUserAdmin([FromBody] CreateColeccionUserAdminDto dto)
        => Ok(await _createColeccionUserAdminController.Handle(dto));

}