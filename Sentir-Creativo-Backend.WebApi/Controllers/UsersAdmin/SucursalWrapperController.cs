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
    
    public SucursalWrapperController(
        ICreateSucursalController createSucursalController,
        IGetAllSucursalController getAllSucursalController)
    {
        _createSucursalController = createSucursalController;
        _getAllSucursalController = getAllSucursalController;
    }
    
    [HttpPost(Name = "CreateSucursal")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateAudiencia([FromBody] CreateSucursalDto dto)
        => Ok(await _createSucursalController.Handle(dto));
    
    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<GetAllSucursalViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<GetAllSucursalViewModel>>> GetAllSucursal()
        => Ok(await _getAllSucursalController.Handle());
}