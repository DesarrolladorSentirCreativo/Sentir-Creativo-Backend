using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.UsuarioAdmins;

namespace Sentir_Creativo_Backend.WebApi.Controllers.UsersAdmin;

[ApiController]
[Route("api/v1/usuarios-admin")]
public class UsuarioAdminWrapperController : ControllerBase
{
    private readonly ICreateUsuarioAdminController _createUsuarioAdminController;
    
    public UsuarioAdminWrapperController(ICreateUsuarioAdminController createUsuarioAdminController)
    {
        _createUsuarioAdminController = createUsuarioAdminController;
    }
    
    [HttpPost(Name = "CreateUsuarioAdmin")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateUsuarioAdmin([FromBody] CreateUsuarioAdminDto dto)
        => Ok(await _createUsuarioAdminController.Handle(dto));
}