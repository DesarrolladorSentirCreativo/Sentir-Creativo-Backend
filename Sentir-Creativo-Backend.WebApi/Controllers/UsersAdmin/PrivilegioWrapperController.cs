using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Privilegios;

namespace Sentir_Creativo_Backend.WebApi.Controllers.UsersAdmin;

[ApiController]
[Route("api/v1/privilegios")]
public class PrivilegioWrapperController : ControllerBase
{
    private readonly ICreatePrivilegioController _createPrivilegioController;

    public PrivilegioWrapperController(ICreatePrivilegioController createPrivilegioController)
    {
        _createPrivilegioController = createPrivilegioController;
    }
    
    [HttpPost(Name = "CreatePrivilegio")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreatePrivilegio([FromBody] CreatePrivilegioDto dto)
        => Ok(await _createPrivilegioController.Handle(dto));

}