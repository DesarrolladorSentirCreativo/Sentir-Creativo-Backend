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
    private readonly IDeleteRolController _deleteRolController;
    private readonly IGetByIdRolController _getByIdRolController;
    public RolWrapperController(ICreateRolController createRolController,
        IGetAllRolController getAllRolController,
        IUpdateRolController updateRolController,
        IDeleteRolController deleteRolController,
        IGetByIdRolController getByIdRolController)
    {
        _createRolController = createRolController;
        _getAllRolController = getAllRolController;
        _updateRolController = updateRolController;
        _deleteRolController = deleteRolController;
        _getByIdRolController = getByIdRolController;
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
    
    [HttpPut("{id}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> DeleteRol(int id)
        => Ok(await _deleteRolController.Handle(id));
    
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(GetByIdRolViewModel),(int)HttpStatusCode.OK)]
    public async Task<ActionResult<GetByIdRolViewModel>> GetByIdRol(int id)
        =>Ok(await _getByIdRolController.Handle(id));

}