using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Privilegios;

namespace Sentir_Creativo_Backend.WebApi.Controllers.UsersAdmin;

[ApiController]
[Route("api/v1/privilegios")]
public class PrivilegioWrapperController : ControllerBase
{
    private readonly ICreatePrivilegioController _createPrivilegioController;
    private readonly IGetAllPrivilegioController _getAllPrivilegioController;
    private readonly IUpdatePrivilegioController _updatePrivilegioController;
    private readonly IDeletePrivilegioController _deletePrivilegioController;

    public PrivilegioWrapperController(
        ICreatePrivilegioController createPrivilegioController,
        IGetAllPrivilegioController getAllPrivilegioController,
        IUpdatePrivilegioController updatePrivilegioController,
        IDeletePrivilegioController deletePrivilegioController)
    {
        _createPrivilegioController = createPrivilegioController;
        _getAllPrivilegioController = getAllPrivilegioController;
        _updatePrivilegioController = updatePrivilegioController;
        _deletePrivilegioController = deletePrivilegioController;
    }
    
    [HttpPost(Name = "CreatePrivilegio")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreatePrivilegio([FromBody] CreatePrivilegioDto dto)
        => Ok(await _createPrivilegioController.Handle(dto));
    
    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<GetAllPrivilegioViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<GetAllPrivilegioViewModel>>> GetAllPrivilegio()
        => Ok(await _getAllPrivilegioController.Handle());
    
    [HttpPut(Name = "UpdatePrivilegio")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> UpdatePrivilegio([FromBody] UpdatePrivilegioDto dto)
        => Ok(await _updatePrivilegioController.Handle(dto));
    
    [HttpPut("{id}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<string>> DeletePrivilegio(string id)
        => Ok(await _deletePrivilegioController.Handle(id));

}