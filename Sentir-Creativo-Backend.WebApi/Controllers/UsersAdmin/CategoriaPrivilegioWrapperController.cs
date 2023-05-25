using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.CategoriaPrivilegios;

namespace Sentir_Creativo_Backend.WebApi.Controllers.UsersAdmin;

[ApiController]
[Route("api/v1/categorias-privilegios")]
public class CategoriaPrivilegioWrapperController: ControllerBase
{
    private readonly ICreateCategoriaPrivilegioController _createSCategoriaPrivilegioController;
    private readonly IGetAllCategoriaPrivilegioController _getAllSCategoriaPrivilegioController;
    private readonly IUpdateCategoriaPrivilegioController _updateSCategoriaPrivilegioController;
    private readonly IDeleteCategoriaPrivilegioController _deleteSCategoriaPrivilegioController;
    private readonly IGetByIdCategoriaPrivilegioController _getByIdCategoriaPrivilegioController;
    private readonly ISelectCategoriaPrivilegioController _selectCategoriaPrivilegioController;
    
    public CategoriaPrivilegioWrapperController(
        ICreateCategoriaPrivilegioController createSCategoriaPrivilegioController,
        IGetAllCategoriaPrivilegioController getAllSCategoriaPrivilegioController,
        IUpdateCategoriaPrivilegioController updateSCategoriaPrivilegioController,
        IDeleteCategoriaPrivilegioController deleteSCategoriaPrivilegioController,
        IGetByIdCategoriaPrivilegioController getByIdCategoriaPrivilegioController,
        ISelectCategoriaPrivilegioController selectCategoriaPrivilegioController)
    {
        _createSCategoriaPrivilegioController = createSCategoriaPrivilegioController;
        _getAllSCategoriaPrivilegioController = getAllSCategoriaPrivilegioController;
        _updateSCategoriaPrivilegioController = updateSCategoriaPrivilegioController;
        _deleteSCategoriaPrivilegioController = deleteSCategoriaPrivilegioController;
        _getByIdCategoriaPrivilegioController = getByIdCategoriaPrivilegioController;
        _selectCategoriaPrivilegioController = selectCategoriaPrivilegioController;
    }
    
    [HttpPost(Name = "CreateCategoriaPrivilegio")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateCategoriaPrivilegio([FromBody] CreateCategoriaPrivilegioDto dto)
        => Ok(await _createSCategoriaPrivilegioController.Handle(dto));
    
    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<GetAllCategoriaPrivilegioViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<GetAllCategoriaPrivilegioViewModel>>> GetAllCategoriaPrivilegio()
        => Ok(await _getAllSCategoriaPrivilegioController.Handle());
    
    [HttpPut(Name = "UpdateCategoriaPrivilegio")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> UpdateCategoriaPrivilegio([FromBody] UpdateCategoriaPrivilegioDto dto)
        => Ok(await _updateSCategoriaPrivilegioController.Handle(dto));
    
    [HttpPut("{id}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> DeleteCategoriaPrivilegio(int id)
        => Ok(await _deleteSCategoriaPrivilegioController.Handle(id));

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(GetByIdCategoriaPrivilegioViewModel),(int)HttpStatusCode.OK)]
    public async Task<ActionResult<GetByIdCategoriaPrivilegioViewModel>> GetByIdCategoriaPrivilegio(int id)
        =>Ok(await _getByIdCategoriaPrivilegioController.Handle(id));
    
    [HttpGet]
    [Route("select")] 
    [ProducesResponseType(typeof(SelectCategoriaPrivilegioViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectCategoriaPrivilegioViewModel>>> SelectCategoriaPrivilegio() 
        => Ok(await _selectCategoriaPrivilegioController.Handle());
}