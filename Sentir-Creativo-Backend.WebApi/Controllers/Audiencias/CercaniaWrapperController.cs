using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Cercanias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Cercanias;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Audiencias;

[ApiController]
[Route("api/v1/cercanias")]
public class CercaniaWrapperController : ControllerBase
{
    private readonly ISelectCercaniaController _selectCercaniaController;
    
    public CercaniaWrapperController(ISelectCercaniaController selectCercaniaController)
    {
        _selectCercaniaController = selectCercaniaController;
    }
    
    [HttpGet(Name = "SelectCercania")]
    [ProducesResponseType(typeof(SelectCercaniaViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectCercaniaViewModel>>> SelectCercania()
        => Ok(await _selectCercaniaController.Handle()); 
}