using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Organizaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO.Organizaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Organizaciones;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Audiencias;

[ApiController]
[Route("api/v1/organizaciones")]
public class OrganizacionWrapperController : ControllerBase
{
    private readonly ISelectOrganizacionController _selectOrganizacionController;
    private readonly IGetAllOrganizacionController _getAllOrganizacionController;
    private readonly ICreateOrganizacionController _createOrganizacionController;
    private readonly IDeleteOrganizacionController _deleteOrganizacionController;
    
    public OrganizacionWrapperController(
        ISelectOrganizacionController selectOrganizacionController,
        IGetAllOrganizacionController getAllOrganizacionController,
        ICreateOrganizacionController createOrganizacionController,
        IDeleteOrganizacionController deleteOrganizacionController)
    {
        _selectOrganizacionController = selectOrganizacionController;
        _getAllOrganizacionController = getAllOrganizacionController;
        _createOrganizacionController = createOrganizacionController;
        _deleteOrganizacionController = deleteOrganizacionController;
    }
    
    [HttpGet]
    [Route("select")] 
    [ProducesResponseType(typeof(SelectOrganizacionViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectOrganizacionViewModel>>> SelectOrganizacion() 
        => Ok(await _selectOrganizacionController.Handle());
    
    [HttpGet("all")]
    [ProducesResponseType(typeof(IReadOnlyList<GetAllOrganizacionViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<GetAllOrganizacionViewModel>>> GetAllOrganizacion()
        => Ok(await _getAllOrganizacionController.Handle());
    
    [HttpPost(Name = "CreateOrganizacion")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateOrganizacion([FromBody] CreateOrganizacionDto dto)
        => Ok(await _createOrganizacionController.Handle(dto));
    
    [HttpDelete("{id}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> DeleteOrganizacion(int id)
        => Ok(await _deleteOrganizacionController.Handle(id));
}