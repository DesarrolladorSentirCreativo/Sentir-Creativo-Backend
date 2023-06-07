using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.AcuerdosUserAdmin;

namespace Sentir_Creativo_Backend.WebApi.Controllers.UsersAdmin;

[ApiController]
[Route("api/v1/acuerdos-admin")]
public class AcuerdoUserAdminWrapperController : ControllerBase
{
    private readonly ICreateAcuerdoUserAdminController _createAcuerdoUserAdminController;

    public AcuerdoUserAdminWrapperController(
        ICreateAcuerdoUserAdminController createAcuerdoUserAdminController)
    {
        _createAcuerdoUserAdminController = createAcuerdoUserAdminController;
    }
    
    [HttpPost(Name = "CreateAcuerdoUserAdmin")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateAcuerdoUserAdmin([FromBody] CreateAcuerdoUserAdminDto dto)
        => Ok(await _createAcuerdoUserAdminController.Handle(dto));
}