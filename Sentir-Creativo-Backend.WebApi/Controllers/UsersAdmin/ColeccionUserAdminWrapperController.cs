using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.ColeccionesUserAdmin;

namespace Sentir_Creativo_Backend.WebApi.Controllers.UsersAdmin;

[ApiController]
[Route("api/v1/colecciones-admin")]
public class ColeccionUserAdminWrapperController : ControllerBase
{
    private readonly ICreateColeccionUserAdminController _createColeccionUserAdminController;
    private readonly IGetAllColeccionUserAdminController _getAllColeccionUserAdminController;
    private readonly IUpdateColeccionUserAdminController _updateColeccionUserAdminController;
    
    public ColeccionUserAdminWrapperController(
        ICreateColeccionUserAdminController createColeccionUserAdminController,
        IGetAllColeccionUserAdminController getAllColeccionUserAdminController,
        IUpdateColeccionUserAdminController updateColeccionUserAdminController)
    {
        _createColeccionUserAdminController = createColeccionUserAdminController;
        _getAllColeccionUserAdminController = getAllColeccionUserAdminController;
        _updateColeccionUserAdminController = updateColeccionUserAdminController;
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

}