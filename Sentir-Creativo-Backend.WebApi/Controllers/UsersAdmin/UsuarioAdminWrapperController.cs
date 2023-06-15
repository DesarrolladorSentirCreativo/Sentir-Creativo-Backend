using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.UsuarioAdmins;

namespace Sentir_Creativo_Backend.WebApi.Controllers.UsersAdmin;

[ApiController]
[Route("api/v1/usuarios-admin")]
public class UsuarioAdminWrapperController : ControllerBase
{
    private readonly ICreateUsuarioAdminController _createUsuarioAdminController;
    private readonly IGetAllUsuarioAdminController _getAllUsuarioAdminController;
    private readonly IUpdateUsuarioAdminController _updateUsuarioAdminController;
    
    public UsuarioAdminWrapperController(
        ICreateUsuarioAdminController createUsuarioAdminController, 
        IGetAllUsuarioAdminController getAllUsuarioAdminController,
        IUpdateUsuarioAdminController updateUsuarioAdminController)
    {
        _createUsuarioAdminController = createUsuarioAdminController;
        _getAllUsuarioAdminController = getAllUsuarioAdminController;
        _updateUsuarioAdminController = updateUsuarioAdminController;
    }
    
    [HttpPost(Name = "CreateUsuarioAdmin")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateUsuarioAdmin([FromBody] CreateUsuarioAdminDto dto)
        => Ok(await _createUsuarioAdminController.Handle(dto));
    
    [HttpGet(Name = "GetAllUsuarioAdmin")]
    [ProducesResponseType(typeof(IReadOnlyList<GetAllUsuarioAdminViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<GetAllUsuarioAdminViewModel>>> GetAllUsuarioAdmin()
        => Ok(await _getAllUsuarioAdminController.Handle());
    
    [HttpPut("{id}", Name = "UpdateUsuarioAdmin")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> UpdateUsuarioAdmin([FromBody] UpdateUsuarioAdminDto dto)
        => Ok(await _updateUsuarioAdminController.Handle(dto));
    
    
}