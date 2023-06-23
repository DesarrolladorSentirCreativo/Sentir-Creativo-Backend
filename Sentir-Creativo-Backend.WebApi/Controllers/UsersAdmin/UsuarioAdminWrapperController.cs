using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.UsuarioAdmins;

namespace Sentir_Creativo_Backend.WebApi.Controllers.UsersAdmin;

[ApiController]
[Route("api/v1/usuarios-admin")]
public class UsuarioAdminWrapperController : ControllerBase
{
    private readonly ICreateUsuarioAdminController _createUsuarioAdminController;
    private readonly IGetAllUsuarioAdminController _getAllUsuarioAdminController;
    private readonly IUpdateUsuarioAdminController _updateUsuarioAdminController;
    private readonly IDeleteUsuarioAdminController _deleteUsuarioAdminController;
    private readonly IGetByIdUsuarioAdminController _getByIdUsuarioAdminController;
    private readonly ISelectUsuarioAdminController _selectUsuarioAdminController;
    private readonly ILoginUsuarioAdminController _loginUsuarioAdminController;
    
    public UsuarioAdminWrapperController(
        ICreateUsuarioAdminController createUsuarioAdminController, 
        IGetAllUsuarioAdminController getAllUsuarioAdminController,
        IUpdateUsuarioAdminController updateUsuarioAdminController,
        IDeleteUsuarioAdminController deleteUsuarioAdminController,
        IGetByIdUsuarioAdminController getByIdUsuarioAdminController,
        ISelectUsuarioAdminController selectUsuarioAdminController,
        ILoginUsuarioAdminController loginUsuarioAdminController)
    {
        _createUsuarioAdminController = createUsuarioAdminController;
        _getAllUsuarioAdminController = getAllUsuarioAdminController;
        _updateUsuarioAdminController = updateUsuarioAdminController;
        _deleteUsuarioAdminController = deleteUsuarioAdminController;
        _getByIdUsuarioAdminController = getByIdUsuarioAdminController;
        _selectUsuarioAdminController = selectUsuarioAdminController;
        _loginUsuarioAdminController = loginUsuarioAdminController;
        
    }
    
    [HttpPost(Name = "CreateUsuarioAdmin")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateUsuarioAdmin([FromBody] CreateUsuarioAdminDto dto)
        => Ok(await _createUsuarioAdminController.Handle(dto));
    
    [HttpGet(Name = "GetAllUsuarioAdmin")]
    [ProducesResponseType(typeof(IReadOnlyList<GetAllUsuarioAdminViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<GetAllUsuarioAdminViewModel>>> GetAllUsuarioAdmin()
        => Ok(await _getAllUsuarioAdminController.Handle());
    
    [HttpPut(Name = "UpdateUsuarioAdmin")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> UpdateUsuarioAdmin([FromBody] UpdateUsuarioAdminDto dto)
        => Ok(await _updateUsuarioAdminController.Handle(dto));
    
    [HttpPut("{id}", Name = "DeleteUsuarioAdmin")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> DeleteUsuarioAdmin(int id)
        => Ok(await _deleteUsuarioAdminController.Handle(id));
    
    [HttpGet("{id}", Name = "GetByIdUsuarioAdmin")]
    [ProducesResponseType(typeof(GetByIdUsuarioAdminViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<GetByIdUsuarioAdminViewModel>> GetByIdUsuarioAdmin(int id)
        => Ok(await _getByIdUsuarioAdminController.Handle(id));
    
    [HttpGet]
    [Route("select")] 
    [ProducesResponseType(typeof(SelectUsuarioAdminViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectUsuarioAdminViewModel>>> SelectUsuarioAdmin() 
        => Ok(await _selectUsuarioAdminController.Handle());

    [HttpPost]
    [Route("login")]
    [ProducesResponseType(typeof(LoginUsuarioAdminViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<LoginUsuarioAdminViewModel>> LoginUsuarioAdmin([FromBody] LoginUsuarioAdminDto dto)
    => Ok(await _loginUsuarioAdminController.Handle(dto));
}