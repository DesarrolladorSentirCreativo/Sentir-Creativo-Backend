using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Privilegios;

namespace Sentir_Creativo_Backend.WebApi.Controllers.UsersAdmin;

[ApiController]
[Route("api/v1/privilegios")]
public class PrivilegioWrapperController : ControllerBase
{
    private readonly ICreatePrivilegioController _createPrivilegioController;
    private readonly IGetAllPrivilegioController _getAllPrivilegioController;
    private readonly IUpdatePrivilegioController _updatePrivilegioController;
    private readonly IDeletePrivilegioController _deletePrivilegioController;
    private readonly ISelectPrivilegioController _selectPrivilegioController;
    private readonly IGetByIdPrivilegioController _getByIdPrivilegioController;

    public PrivilegioWrapperController(
        ICreatePrivilegioController createPrivilegioController,
        IGetAllPrivilegioController getAllPrivilegioController,
        IUpdatePrivilegioController updatePrivilegioController,
        IDeletePrivilegioController deletePrivilegioController,
        ISelectPrivilegioController selectPrivilegioController,
        IGetByIdPrivilegioController getByIdPrivilegioController)
    {
        _createPrivilegioController = createPrivilegioController;
        _getAllPrivilegioController = getAllPrivilegioController;
        _updatePrivilegioController = updatePrivilegioController;
        _deletePrivilegioController = deletePrivilegioController;
        _selectPrivilegioController = selectPrivilegioController;
        _getByIdPrivilegioController = getByIdPrivilegioController;
    }
    
    [HttpPost(Name = "CreatePrivilegio")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreatePrivilegio([FromBody] CreatePrivilegioDto dto)
        => Ok(await _createPrivilegioController.Handle(dto));
    
    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<GetAllPrivilegioViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<GetAllPrivilegioViewModel>>> GetAllPrivilegio()
        => Ok(await _getAllPrivilegioController.Handle());
    
    [HttpPut(Name = "UpdatePrivilegio")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> UpdatePrivilegio([FromBody] UpdatePrivilegioDto dto)
        => Ok(await _updatePrivilegioController.Handle(dto));
    
    [HttpPut("{id}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<string>> DeletePrivilegio(string id)
        => Ok(await _deletePrivilegioController.Handle(id));
    
    [HttpGet]
    [Route("select")] 
    [ProducesResponseType(typeof(SelectPrivilegioViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectPrivilegioViewModel>>> SelectPrivilegio() 
        => Ok(await _selectPrivilegioController.Handle());
    
        
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(GetByIdPrivilegioViewModel),(int)HttpStatusCode.OK)]
    public async Task<ActionResult<GetByIdPrivilegioViewModel>> GetByIdPrivilegio(string id)
        =>Ok(await _getByIdPrivilegioController.Handle(id));

}