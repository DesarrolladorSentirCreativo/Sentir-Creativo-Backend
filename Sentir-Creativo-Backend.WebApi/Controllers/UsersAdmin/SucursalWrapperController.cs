using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Sucursales;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Sucursales;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Sucursales;

namespace Sentir_Creativo_Backend.WebApi.Controllers.UsersAdmin;

[ApiController]
[Route("api/v1/sucursales")]
public class SucursalWrapperController : ControllerBase
{
    private readonly ICreateSucursalController _createSucursalController;
    private readonly IGetAllSucursalController _getAllSucursalController;
    private readonly IUpdateSucursalController _updateSucursalController;
    private readonly IDeleteSucursalController _deleteSucursalController;
    
    public SucursalWrapperController(
        ICreateSucursalController createSucursalController,
        IGetAllSucursalController getAllSucursalController,
        IUpdateSucursalController updateSucursalController, 
        IDeleteSucursalController deleteSucursalController)
    {
        _createSucursalController = createSucursalController;
        _getAllSucursalController = getAllSucursalController;
        _updateSucursalController = updateSucursalController;
        _deleteSucursalController = deleteSucursalController;
    }
    
    [HttpPost(Name = "CreateSucursal")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateAudiencia([FromBody] CreateSucursalDto dto)
        => Ok(await _createSucursalController.Handle(dto));
    
    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<GetAllSucursalViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<GetAllSucursalViewModel>>> GetAllSucursal()
        => Ok(await _getAllSucursalController.Handle());
    
    [HttpPut(Name = "UpdateSucursal")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> UpdateAudiencia([FromBody] UpdateSucursalDto dto)
        => Ok(await _updateSucursalController.Handle(dto));
    
    
    [HttpPut("{id}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> DeleteSucursal(int id)
        => Ok(await _deleteSucursalController.Handle(id));
}