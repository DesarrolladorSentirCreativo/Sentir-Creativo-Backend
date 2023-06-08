using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Roles;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Roles;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Roles;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.Roles;

namespace Sentir_Creativo_Backend.WebApi.Controllers.UsersAdmin;

[ApiController]
[Route("api/v1/roles")]
public class RolWrapperController : ControllerBase
{
    private readonly ICreateRolController _createRolController;
    private readonly IGetAllRolController _getAllRolController;
    private readonly IUpdateRolController _updateRolController;
    public RolWrapperController(ICreateRolController createRolController,
        IGetAllRolController getAllRolController,
        IUpdateRolController updateRolController)
    {
        _createRolController = createRolController;
        _getAllRolController = getAllRolController;
        _updateRolController = updateRolController;
    }
    
    [HttpPost(Name = "CreateRol")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateRol([FromBody] CreateRolDto dto)
        => Ok(await _createRolController.Handle(dto));
    
    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<GetAllRolPresenter>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<GetAllRolViewModel>>> GetAllRol()
        => Ok(await _getAllRolController.Handle());
    
    [HttpPut(Name = "UpdateRol")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> UpdateRol([FromBody] UpdateRolDto dto)
        => Ok(await _updateRolController.Handle(dto));

}