using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.CategoriaUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.CategoriaUserAdmins;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.CategoriaUserAdmins;

namespace Sentir_Creativo_Backend.WebApi.Controllers.UsersAdmin;

[Authorize]
[ApiController]
[Route("api/v1/categorias-userAdmins")]
public class CategoriaUserAdminWrapperController : ControllerBase
{
    private readonly ICreateCategoriaUserAdminController _createCategoriaUserAdminController;
    private readonly IGetAllCategoriaUserAdminController _getAllCategoriaUserAdminController;
    private readonly IUpdateCategoriaUserAdminController _updateCategoriaUserAdminController;
    private readonly IDeleteCategoriaUserAdminController _deleteCategoriaUserAdminController;
    private readonly IGetByIdCategoriaUserAdminController _getByIdCategoriaUserAdminController;
    private readonly ISelectCategoriaUserAdminController _selectCategoriaUserAdminController;
    
    public CategoriaUserAdminWrapperController(
        ICreateCategoriaUserAdminController createCategoriaUserAdminController,
        IGetAllCategoriaUserAdminController getAllCategoriaUserAdminController,
        IUpdateCategoriaUserAdminController updateCategoriaUserAdminController,
        IDeleteCategoriaUserAdminController deleteCategoriaUserAdminController,
        IGetByIdCategoriaUserAdminController getByIdCategoriaUserAdminController,
        ISelectCategoriaUserAdminController selectCategoriaUserAdminController)
    {
        _createCategoriaUserAdminController = createCategoriaUserAdminController;
        _getAllCategoriaUserAdminController = getAllCategoriaUserAdminController;
        _updateCategoriaUserAdminController = updateCategoriaUserAdminController;
        _deleteCategoriaUserAdminController = deleteCategoriaUserAdminController;
        _getByIdCategoriaUserAdminController = getByIdCategoriaUserAdminController;
        _selectCategoriaUserAdminController = selectCategoriaUserAdminController;
    }
    
    [HttpPost(Name = "CreateCategoriaUserAdmin")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateCategoriaUserAdmin([FromBody] CreateCategoriaUserAdminDto dto)
        => Ok(await _createCategoriaUserAdminController.Handle(dto));
    
    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<GetAllCategoriaUserAdminPresenter>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<GetAllCategoriaUserAdminViewModel>>> GetAlCategoriaUserAdmin()
        => Ok(await _getAllCategoriaUserAdminController.Handle());
    
    [HttpPut(Name = "UpdateCategoriaUserAdmin")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> UpdateCategoriaUserAdmin([FromBody] UpdateCategoriaUserAdminDto dto)
        => Ok(await _updateCategoriaUserAdminController.Handle(dto));
    
    [HttpPut("{id}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> DeleteCategoriaUserAdmin(int id)
        => Ok(await _deleteCategoriaUserAdminController.Handle(id));
    
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(GetByIdCategoriaUserAdminViewModel),(int)HttpStatusCode.OK)]
    public async Task<ActionResult<GetByIdCategoriaUserAdminViewModel>> GetByIdCategoriaUserAdmin(int id)
        =>Ok(await _getByIdCategoriaUserAdminController.Handle(id));
    
    [HttpGet]
    [Route("select")] 
    [ProducesResponseType(typeof(SelectCategoriaUserAdminViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectCategoriaUserAdminViewModel>>> SelectCategoriaUserAdmin() 
        => Ok(await _selectCategoriaUserAdminController.Handle());
}