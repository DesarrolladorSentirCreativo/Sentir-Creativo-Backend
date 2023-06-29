using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Areas.BusinessObject.Contracts.Controllers.Areas;
using Sentir_Creativo_Backend.Areas.BusinessObject.ViewModels.Areas;

namespace Sentir_Creativo_Backend.WebApi.Controllers;

[Authorize]
[ApiController]
[Route("api/v1/areas")]
public class AreaWrapperController : ControllerBase
{
    private readonly ISelectAreaController _selectAreaController;
    
    public AreaWrapperController(ISelectAreaController selectAreaController)
    {
        _selectAreaController = selectAreaController;
    }
    
    [HttpGet]
    [Route("/select-area")] 
    [ProducesResponseType(typeof(SelectAreaViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectAreaViewModel>>> SelectArea() 
        => Ok(await _selectAreaController.Handle());
}