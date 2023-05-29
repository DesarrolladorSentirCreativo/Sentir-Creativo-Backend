using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Modulos;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.Modulos;

namespace Sentir_Creativo_Backend.WebApi.Controllers.UsersAdmin;

[ApiController]
[Route("api/v1/modulos")]
public class ModuloWrapperController : ControllerBase
{
    private readonly ICreateModuloController _createModuloController;
    private readonly IGetAllModuloController _getAllModuloController;

    public ModuloWrapperController(
        ICreateModuloController createModuloController,
         IGetAllModuloController getAllModuloController)
    {
        _createModuloController = createModuloController;
        _getAllModuloController = getAllModuloController;
    }
    
    [HttpPost(Name = "CreateModulo")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateModulo([FromBody] CreateModuloDto dto)
        => Ok(await _createModuloController.Handle(dto));
    
    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<GetAllModuloPresenter>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<GetAllModuloViewModel>>> GetAllModulo()
        => Ok(await _getAllModuloController.Handle());
}