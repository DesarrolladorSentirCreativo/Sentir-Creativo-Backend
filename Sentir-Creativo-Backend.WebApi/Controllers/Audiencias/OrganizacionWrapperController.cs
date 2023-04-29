using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Organizaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Organizaciones;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Audiencias;

[ApiController]
[Route("api/v1/organizaciones")]
public class OrganizacionWrapperController : ControllerBase
{
    private readonly ISelectOrganizacionController _selectOrganizacionController;
    private readonly IGetAllOrganizacionController _getAllOrganizacionController;
    
    public OrganizacionWrapperController(
        ISelectOrganizacionController selectOrganizacionController,
        IGetAllOrganizacionController getAllOrganizacionController)
    {
        _selectOrganizacionController = selectOrganizacionController;
        _getAllOrganizacionController = getAllOrganizacionController;
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
    
}