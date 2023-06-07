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
    private readonly IUpdateAcuerdoUserAdminController _updateAcuerdoUserAdminController;
    private readonly IDeleteAcuerdoUserAdminController _deleteAcuerdoUserAdminController;
    private readonly IGetByIdAcuerdoUserAdminControiller _getByIdAcuerdoUserAdminControiller;

    public AcuerdoUserAdminWrapperController(
        ICreateAcuerdoUserAdminController createAcuerdoUserAdminController,
        IGetAllAcuerdoUserAdminController getAllAcuerdoUserAdminController,
        IUpdateAcuerdoUserAdminController updateAcuerdoUserAdminController,
        IDeleteAcuerdoUserAdminController deleteAcuerdoUserAdminController,
        IGetByIdAcuerdoUserAdminControiller getByIdAcuerdoUserAdminControiller)
    {
        _createAcuerdoUserAdminController = createAcuerdoUserAdminController;
        _getAllAcuerdoUserAdminController = getAllAcuerdoUserAdminController;
        _updateAcuerdoUserAdminController = updateAcuerdoUserAdminController;
        _deleteAcuerdoUserAdminController = deleteAcuerdoUserAdminController;
        _getByIdAcuerdoUserAdminControiller = getByIdAcuerdoUserAdminControiller;
    }
    
    [HttpPost(Name = "CreateAcuerdoUserAdmin")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateAcuerdoUserAdmin([FromBody] CreateAcuerdoUserAdminDto dto)
        => Ok(await _createAcuerdoUserAdminController.Handle(dto));
    
    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<GetAllAcuerdoUserAdminViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<GetAllAcuerdoUserAdminViewModel>>> GetAllAcuerdoUserAdmin()
        => Ok(await _getAllAcuerdoUserAdminController.Handle());
    
    [HttpPut(Name = "UpdateAcuerdoUserAdmin")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> UpdateAcuerdoUserAdmin([FromBody] UpdateAcuerdoUserAdminDto dto)
        => Ok(await _updateAcuerdoUserAdminController.Handle(dto));
    
    [HttpPut("{id}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> DeleteAcuerdoUserAdmin(int id)
        => Ok(await _deleteAcuerdoUserAdminController.Handle(id));
    
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(GetByIdAcuerdoUserAdminViewModel),(int)HttpStatusCode.OK)]
    public async Task<ActionResult<GetByIdAcuerdoUserAdminViewModel>> GetByIdAcuerdoUserAdmin(int id)
        =>Ok(await _getByIdAcuerdoUserAdminControiller.Handle(id));
}