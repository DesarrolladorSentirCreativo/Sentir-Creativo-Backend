using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Modulos;

namespace Sentir_Creativo_Backend.WebApi.Controllers.UsersAdmin;

[ApiController]
[Route("api/v1/modulos")]
public class ModuloWrapperController : ControllerBase
{
    private readonly ICreateModuloController _createModuloController;

    public ModuloWrapperController(ICreateModuloController createModuloController)
    {
        _createModuloController = createModuloController;
    }
    
    [HttpPost(Name = "CreateModulo")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateModulo([FromBody] CreateModuloDto dto)
        => Ok(await _createModuloController.Handle(dto));
}