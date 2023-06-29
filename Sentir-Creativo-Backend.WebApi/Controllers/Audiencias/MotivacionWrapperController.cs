using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Motivaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Motivaciones;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Audiencias;

[Authorize]
[ApiController]
[Route("api/v1/motivaciones")]
public class MotivacionWrapperController: ControllerBase
{
    private readonly ISelectMotivacionController _selectMotivacionController;
    
    public MotivacionWrapperController(ISelectMotivacionController selectMotivacionController)
    {
        _selectMotivacionController = selectMotivacionController;
    }

    [HttpGet("select")]
    [ProducesResponseType(typeof(SelectMotivacionViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectMotivacionViewModel>>> SelectMotivacion()
        =>Ok(await _selectMotivacionController.Handle()); 
}