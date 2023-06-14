using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.EstadoUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.EstadoUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.EstadoUserAdmins;

namespace Sentir_Creativo_Backend.WebApi.Controllers.UsersAdmin;

[ApiController]
[Route("api/v1/estados-useradmins")]
public class EstadoUserAdminWrapperController : ControllerBase
{
    private readonly ICreateEstadoUserAdminController _createEstadoUserAdminController;
    private readonly IGetAllEstadoUserAdminController _getAllEstadoUserAdminController;
    private readonly IUpdateEstadoUserAdminController _updateEstadoUserAdminController;
    private readonly IDeleteEstadoUserAdminController _deleteEstadoUserAdminController;
    private readonly IGetByIdEstadoUserAdminController _getByIdEstadoUserAdminControiller;
    private readonly ISelectEstadoUserAdminController _selectEstadoUserAdminController;
    
    public EstadoUserAdminWrapperController(
        ICreateEstadoUserAdminController createEstadoUserAdminController,
        IGetAllEstadoUserAdminController getAllEstadoUserAdminController, 
        IUpdateEstadoUserAdminController updateEstadoUserAdminController, 
        IDeleteEstadoUserAdminController deleteEstadoUserAdminController, 
        IGetByIdEstadoUserAdminController getByIdEstadoUserAdminControiller, 
        ISelectEstadoUserAdminController selectEstadoUserAdminController)
    {
        _createEstadoUserAdminController = createEstadoUserAdminController;
        _getAllEstadoUserAdminController = getAllEstadoUserAdminController;
        _updateEstadoUserAdminController = updateEstadoUserAdminController;
        _deleteEstadoUserAdminController = deleteEstadoUserAdminController;
        _getByIdEstadoUserAdminControiller = getByIdEstadoUserAdminControiller;
        _selectEstadoUserAdminController = selectEstadoUserAdminController;
    }
    
    [HttpPost(Name = "CreateEstadoUserAdmin")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateEstadoUserAdmin([FromBody] CreateEstadoUserAdminDto dto)
        => Ok(await _createEstadoUserAdminController.Handle(dto));
    
    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<GetAllEstadoUserAdminViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<GetAllEstadoUserAdminViewModel>>> GetAlEstadoUserAdmin()
        => Ok(await _getAllEstadoUserAdminController.Handle());
    
    [HttpPut(Name = "UpdateEstadoUserAdmin")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> UpdateEstadoUserAdmin([FromBody] UpdateEstadoUserAdminDto dto)
        => Ok(await _updateEstadoUserAdminController.Handle(dto));
    
    [HttpPut("{id}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> DeleteEstadoUserAdmin(int id)
        => Ok(await _deleteEstadoUserAdminController.Handle(id));
    
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(GetByIdEstadoUserAdminViewModel),(int)HttpStatusCode.OK)]
    public async Task<ActionResult<GetByIdEstadoUserAdminViewModel>> GetByIdEstadoUserAdmin(int id)
        =>Ok(await _getByIdEstadoUserAdminControiller.Handle(id));
    
    [HttpGet("select")]
    [ProducesResponseType(typeof(IReadOnlyList<SelectEstadoUserAdminViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectEstadoUserAdminViewModel>>> SelectEstadoUserAdmin()
        => Ok(await _selectEstadoUserAdminController.Handle());
    
    
    
}