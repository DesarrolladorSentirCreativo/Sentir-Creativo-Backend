using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.ColeccionesUserAdmin;

namespace Sentir_Creativo_Backend.WebApi.Controllers.UsersAdmin;

[Authorize]
[ApiController]
[Route("api/v1/colecciones-admin")]
public class ColeccionUserAdminWrapperController : ControllerBase
{
    private readonly ICreateColeccionUserAdminController _createColeccionUserAdminController;
    private readonly IGetAllColeccionUserAdminController _getAllColeccionUserAdminController;
    private readonly IUpdateColeccionUserAdminController _updateColeccionUserAdminController;
    private readonly IDeleteColeccionUserAdminController _deleteColeccionUserAdminController;
    private readonly IGetByIdColeccionUserAdminController _getByIdColeccionUserAdminController;
    private readonly ISelectColeccionUserAdminController _selectColeccionUserAdminController;
    
    public ColeccionUserAdminWrapperController(
        ICreateColeccionUserAdminController createColeccionUserAdminController,
        IGetAllColeccionUserAdminController getAllColeccionUserAdminController,
        IUpdateColeccionUserAdminController updateColeccionUserAdminController,
        IDeleteColeccionUserAdminController deleteColeccionUserAdminController,
        IGetByIdColeccionUserAdminController getByIdColeccionUserAdminController,
        ISelectColeccionUserAdminController selectColeccionUserAdminController)
    {
        _createColeccionUserAdminController = createColeccionUserAdminController;
        _getAllColeccionUserAdminController = getAllColeccionUserAdminController;
        _updateColeccionUserAdminController = updateColeccionUserAdminController;
        _deleteColeccionUserAdminController = deleteColeccionUserAdminController;
        _getByIdColeccionUserAdminController = getByIdColeccionUserAdminController;
        _selectColeccionUserAdminController = selectColeccionUserAdminController;
    }
    
    [HttpPost(Name = "CreateColeccionUserAdmin")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateColeccionUserAdmin([FromBody] CreateColeccionUserAdminDto dto)
        => Ok(await _createColeccionUserAdminController.Handle(dto));
    
       
    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<GetAllColeccionUserAdminViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<GetAllColeccionUserAdminViewModel>>> GetAllColeccionUserAdmin()
        => Ok(await _getAllColeccionUserAdminController.Handle());
    
    [HttpPut(Name = "UpdateColeccionUserAdmin")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> UpdateColeccionUserAdmin([FromBody] UpdateColeccionUserAdminDto dto)
        => Ok(await _updateColeccionUserAdminController.Handle(dto));
    
    [HttpPut("{id}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> DeleteColeccionUserAdmin(int id)
        => Ok(await _deleteColeccionUserAdminController.Handle(id));
    
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(GetByIdColeccionUserAdminViewModel),(int)HttpStatusCode.OK)]
    public async Task<ActionResult<GetByIdColeccionUserAdminViewModel>> GetByIdColeccionUserAdmin(int id)
        =>Ok(await _getByIdColeccionUserAdminController.Handle(id));
    
    [HttpGet]
    [Route("select")] 
    [ProducesResponseType(typeof(SelectColeccionUserAdminViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectColeccionUserAdminViewModel>>> SelectColeccionUserAdmin() 
        => Ok(await _selectColeccionUserAdminController.Handle());

}