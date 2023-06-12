using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AFP;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.AFP;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AFP;
using Sentir_Creativo_Backend.UsersAdmins.Presenters.AFP;

namespace Sentir_Creativo_Backend.WebApi.Controllers.UsersAdmin;

[ApiController]
[Route("api/v1/afp")]
public class AfpWrapperController : ControllerBase
{
    private readonly ICreateAfpController _createAfpController;
    private readonly IGetAllAfpController _getAllAfpController;
    private readonly IUpdateAfpController _updateAfpController;
    private readonly IDeleteAfpController _deleteAfpController;
    private readonly IGetByIdAfpController _getByIdAfpControiller;
    private readonly ISelectAfpController _selectAfpController;

    public AfpWrapperController(
        ICreateAfpController createAfpController,
        IGetAllAfpController getAllAfpController, 
        IUpdateAfpController updateAfpController, 
        IDeleteAfpController deleteAfpController, 
        IGetByIdAfpController getByIdAfpControiller, 
        ISelectAfpController selectAfpController)
    {
        _createAfpController = createAfpController;
        _getAllAfpController = getAllAfpController;
        _updateAfpController = updateAfpController;
        _deleteAfpController = deleteAfpController;
        _getByIdAfpControiller = getByIdAfpControiller;
        _selectAfpController = selectAfpController;
    }

    [HttpPost(Name = "CreateAfp")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateAfp([FromBody] CreateAfpDto dto)
        => Ok(await _createAfpController.Handle(dto));
    
    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<GetAllAfpPresenter>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<GetAllAfpViewModel>>> GetAlAfp()
        => Ok(await _getAllAfpController.Handle());
    
    [HttpPut(Name = "UpdateAfp")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> UpdateAfp([FromBody] UpdateAfpDto dto)
        => Ok(await _updateAfpController.Handle(dto));
    
    [HttpPut("{id}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> DeleteAfp(int id)
        => Ok(await _deleteAfpController.Handle(id));
    
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(GetByIdAfpViewModel),(int)HttpStatusCode.OK)]
    public async Task<ActionResult<GetByIdAfpViewModel>> GetByIdAfp(int id)
        =>Ok(await _getByIdAfpControiller.Handle(id));
    
    [HttpGet]
    [Route("select")] 
    [ProducesResponseType(typeof(SelectAfpViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectAfpViewModel>>> SelectAfp() 
        => Ok(await _selectAfpController.Handle());

    
}