using System.Net;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Antiguedades;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Antiguedades;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Audiencias;

[ApiController]
[Route("api/v1/antiguedades")]
public class AntiguedadWrapperController : ControllerBase
{
    private readonly ISelectAntiguedadController _selectAntiguedadController;
    
    public AntiguedadWrapperController(ISelectAntiguedadController selectAntiguedadController)
    {
        _selectAntiguedadController = selectAntiguedadController;
    }

    [HttpGet]
    [Route("/select-antiguedad")] 
    [ProducesResponseType(typeof(IReadOnlyList<SelectAntiguedadViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectAntiguedadViewModel>>> SelectAntiguedad()
        => Ok(await _selectAntiguedadController.Handle());
    
}