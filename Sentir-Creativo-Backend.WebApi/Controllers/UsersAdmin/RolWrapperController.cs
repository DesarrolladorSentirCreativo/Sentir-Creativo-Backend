using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Roles;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Roles;

namespace Sentir_Creativo_Backend.WebApi.Controllers.UsersAdmin;

[ApiController]
[Route("api/v1/roles")]
public class RolWrapperController : ControllerBase
{
    private readonly ICreateRolController _createRolController;
    
    public RolWrapperController(ICreateRolController createRolController)
    {
        _createRolController = createRolController;
    }
    
    [HttpPost(Name = "CreateRol")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateRol([FromBody] CreateRolDto dto)
        => Ok(await _createRolController.Handle(dto));
}