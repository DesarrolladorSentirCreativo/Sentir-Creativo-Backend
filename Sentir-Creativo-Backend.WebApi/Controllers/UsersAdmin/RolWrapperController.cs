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
    private readonly ISelectRolController _selectRolController;
    
    public RolWrapperController(ICreateRolController createRolController,
        IGetAllRolController getAllRolController,
        IUpdateRolController updateRolController,
        IDeleteRolController deleteRolController,
        IGetByIdRolController getByIdRolController,
        ISelectRolController selectRolController)
    {
        _createRolController = createRolController;
        _getAllRolController = getAllRolController;
        _updateRolController = updateRolController;
        _deleteRolController = deleteRolController;
        _getByIdRolController = getByIdRolController;
        _selectRolController = selectRolController;
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
    
    [HttpGet]
    [Route("select")] 
    [ProducesResponseType(typeof(SelectRolViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectRolViewModel>>> SelectRol() 
        => Ok(await _selectRolController.Handle());

}