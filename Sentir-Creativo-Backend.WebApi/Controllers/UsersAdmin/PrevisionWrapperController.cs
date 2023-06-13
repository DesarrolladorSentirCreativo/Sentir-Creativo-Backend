using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Previsiones;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Previsiones;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Previsiones;

namespace Sentir_Creativo_Backend.WebApi.Controllers.UsersAdmin;

[ApiController]
[Route("api/v1/previsiones")]
public class PrevisionWrapperController : ControllerBase
{
    private readonly ICreatePrevisionController _createPrevisionController;
    private readonly IGetAllPrevisionController _getAllPrevisionController;
    private readonly IUpdatePrevisionController _updatePrevisionController;
    private readonly IDeletePrevisionController _deletePrevisionController;
    private readonly IGetByIdPrevisionController _getByIdPrevisionControiller;
    private readonly ISelectPrevisionController _selectPrevisionController;
    
    public PrevisionWrapperController(
        ICreatePrevisionController createPrevisionController,
        IGetAllPrevisionController getAllPrevisionController, 
        IUpdatePrevisionController updatePrevisionController, 
        IDeletePrevisionController deletePrevisionController, 
        IGetByIdPrevisionController getByIdPrevisionControiller, 
        ISelectPrevisionController selectPrevisionController)
    {
        _createPrevisionController = createPrevisionController;
        _getAllPrevisionController = getAllPrevisionController;
        _updatePrevisionController = updatePrevisionController;
        _deletePrevisionController = deletePrevisionController;
        _getByIdPrevisionControiller = getByIdPrevisionControiller;
        _selectPrevisionController = selectPrevisionController;
    }
    
    [HttpPost(Name = "CreatePrevision")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreatePrevision([FromBody] CreatePrevisionDto dto)
        => Ok(await _createPrevisionController.Handle(dto));
    
    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<GetAllPrevisionViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<GetAllPrevisionViewModel>>> GetAlPrevision()
        => Ok(await _getAllPrevisionController.Handle());
    
    [HttpPut(Name = "UpdatePrevision")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> UpdatePrevision([FromBody] UpdatePrevisionDto dto)
        => Ok(await _updatePrevisionController.Handle(dto));
    
    [HttpPut("{id}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> DeletePrevision(int id)
        => Ok(await _deletePrevisionController.Handle(id));
    
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(GetByIdPrevisionViewModel),(int)HttpStatusCode.OK)]
    public async Task<ActionResult<GetByIdPrevisionViewModel>> GetByIdPrevision(int id)
        =>Ok(await _getByIdPrevisionControiller.Handle(id));
    
    [HttpGet("select")]
    [ProducesResponseType(typeof(IReadOnlyList<SelectPrevisionViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectPrevisionViewModel>>> SelectPrevision()
        => Ok(await _selectPrevisionController.Handle());
    
    
}