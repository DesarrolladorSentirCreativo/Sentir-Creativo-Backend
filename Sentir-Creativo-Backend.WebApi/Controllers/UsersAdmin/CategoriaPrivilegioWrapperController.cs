using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaPrivilegios;
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
    
    public CategoriaPrivilegioWrapperController(
        ICreateCategoriaPrivilegioController createSCategoriaPrivilegioController,
        IGetAllCategoriaPrivilegioController getAllSCategoriaPrivilegioController,
        IUpdateCategoriaPrivilegioController updateSCategoriaPrivilegioController)
    {
        _createSCategoriaPrivilegioController = createSCategoriaPrivilegioController;
        _getAllSCategoriaPrivilegioController = getAllSCategoriaPrivilegioController;
        _updateSCategoriaPrivilegioController = updateSCategoriaPrivilegioController;
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
}