using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AcuerdosUserAdmin;

namespace Sentir_Creativo_Backend.WebApi.Controllers.UsersAdmin;

[ApiController]
[Route("api/v1/acuerdos-admin")]
public class AcuerdoUserAdminWrapperController : ControllerBase
{
    private readonly ICreateAcuerdoUserAdminController _createAcuerdoUserAdminController;
    private readonly IGetAllAcuerdoUserAdminController _getAllAcuerdoUserAdminController;

    public AcuerdoUserAdminWrapperController(
        ICreateAcuerdoUserAdminController createAcuerdoUserAdminController,
        IGetAllAcuerdoUserAdminController getAllAcuerdoUserAdminController)
    {
        _createAcuerdoUserAdminController = createAcuerdoUserAdminController;
        _getAllAcuerdoUserAdminController = getAllAcuerdoUserAdminController;
    }
    
    [HttpPost(Name = "CreateAcuerdoUserAdmin")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateAcuerdoUserAdmin([FromBody] CreateAcuerdoUserAdminDto dto)
        => Ok(await _createAcuerdoUserAdminController.Handle(dto));
    
    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<GetAllAcuerdoUserAdminViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<GetAllAcuerdoUserAdminViewModel>>> GetAllAcuerdoUserAdmin()
        => Ok(await _getAllAcuerdoUserAdminController.Handle());
}