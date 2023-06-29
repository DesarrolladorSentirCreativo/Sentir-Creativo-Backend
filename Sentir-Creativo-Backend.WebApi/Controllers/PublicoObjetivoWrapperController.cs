using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Controllers.PublicoObjetivos;
using Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.WebApi.Controllers;

[Authorize]
[ApiController]
[Route("api/v1/publicos-objetivos")]
public class PublicoObjetivoWrapperController : ControllerBase
{
    private readonly ISelectPublicoObjetivoController _selectPublicoObjetivoController;
    
    public PublicoObjetivoWrapperController(ISelectPublicoObjetivoController selectPublicoObjetivoController)
    {
        _selectPublicoObjetivoController = selectPublicoObjetivoController;
    }
    
    [HttpGet]
    [Route("/select-publico-objetivo")] 
    [ProducesResponseType(typeof(SelectPublicoObjetivoViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectPublicoObjetivoViewModel>>> SelectPublicoObjetivo() 
        => Ok(await _selectPublicoObjetivoController.Handle());
}