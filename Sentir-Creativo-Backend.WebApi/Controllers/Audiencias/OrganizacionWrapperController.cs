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
    
    public OrganizacionWrapperController(ISelectOrganizacionController selectOrganizacionController)
    {
        _selectOrganizacionController = selectOrganizacionController;
    }
    
    [HttpGet]
    [Route("select")] 
    [ProducesResponseType(typeof(SelectOrganizacionViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectOrganizacionViewModel>>> SelectOrganizacion() 
        => Ok(await _selectOrganizacionController.Handle());
    
}