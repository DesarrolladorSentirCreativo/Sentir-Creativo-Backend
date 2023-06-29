using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ModoTrabajos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.ModoTrabajos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AFP;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.ModoTrabajos;

namespace Sentir_Creativo_Backend.WebApi.Controllers.UsersAdmin;

[Authorize]
[ApiController]
[Route("api/v1/modos-trabajos")]
public class ModoTrabajoWrapperController : ControllerBase
{
    private readonly ICreateModoTrabajoController _createModoTrabajoController;
    private readonly IGetAllModoTrabajoController _getAllModoTrabajoController;
    private readonly IUpdateModoTrabajoController _updateModoTrabajoController;
    private readonly IDeleteModoTrabajoController _deleteModoTrabajoController;
    private readonly IGetByIdModoTrabajoController _getByIdModoTrabajoController;
    private readonly ISelectModoTrabajoController _selectModoTrabajoController;
    
    public ModoTrabajoWrapperController(
        ICreateModoTrabajoController createModoTrabajoController,
        IGetAllModoTrabajoController getAllModoTrabajoController,
        IUpdateModoTrabajoController updateModoTrabajoController,
        IDeleteModoTrabajoController deleteModoTrabajoController,
        IGetByIdModoTrabajoController getByIdModoTrabajoController,
        ISelectModoTrabajoController selectModoTrabajoController)
    {
        _createModoTrabajoController = createModoTrabajoController;
        _getAllModoTrabajoController = getAllModoTrabajoController;
        _updateModoTrabajoController = updateModoTrabajoController;
        _deleteModoTrabajoController = deleteModoTrabajoController;
        _getByIdModoTrabajoController = getByIdModoTrabajoController;
        _selectModoTrabajoController = selectModoTrabajoController;
    }
    
    [HttpPost(Name = "CreateModoTrabajo")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateModoTrabajo([FromBody] CreateModoTrabajoDto dto)
        => Ok(await _createModoTrabajoController.Handle(dto));
    
    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<GetAllModoTrabajoViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<GetAllAfpViewModel>>> GetAllModoTrabajo()
        => Ok(await _getAllModoTrabajoController.Handle());
    
    [HttpPut(Name = "UpdateModoTrabajo")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> UpdateModoTrabajo([FromBody] UpdateModoTrabajoDto dto)
        => Ok(await _updateModoTrabajoController.Handle(dto));
    
    [HttpPut("{id}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> DeleteModoTrabajo(int id)
        => Ok(await _deleteModoTrabajoController.Handle(id));
    
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(GetByIdModoTrabajoViewModel),(int)HttpStatusCode.OK)]
    public async Task<ActionResult<GetByIdModoTrabajoViewModel>> GetByIdModoTrabajo(int id)
        =>Ok(await _getByIdModoTrabajoController.Handle(id));
    
    [HttpGet]
    [Route("select")] 
    [ProducesResponseType(typeof(SelectModoTrabajoViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectModoTrabajoViewModel>>> SelectModoTrabajo() 
        => Ok(await _selectModoTrabajoController.Handle());
}