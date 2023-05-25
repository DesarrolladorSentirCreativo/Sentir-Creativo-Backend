using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.CategoriaPrivilegios;

namespace Sentir_Creativo_Backend.WebApi.Controllers.UsersAdmin;

[ApiController]
[Route("api/v1/categorias-privilegios")]
public class CategoriaPrivilegioWrapperController: ControllerBase
{
    private readonly ICreateCategoriaPrivilegioController _createSCategoriaPrivilegioController;
    
    public CategoriaPrivilegioWrapperController(
        ICreateCategoriaPrivilegioController createSCategoriaPrivilegioController)
    {
        _createSCategoriaPrivilegioController = createSCategoriaPrivilegioController;
    }
    
    [HttpPost(Name = "CreateCategoriaPrivilegio")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateCategoriaPrivilegio([FromBody] CreateCategoriaPrivilegioDto dto)
        => Ok(await _createSCategoriaPrivilegioController.Handle(dto));
}