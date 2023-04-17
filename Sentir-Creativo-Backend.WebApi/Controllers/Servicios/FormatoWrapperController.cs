using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.Formatos;
using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.Formatos;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Servicios;

[ApiController]
[Route("api/v1/formatos")]
public class FormatoWrapperController : ControllerBase
{
    private readonly ISelectFormatoController _selectFormatoController;
    
    public FormatoWrapperController(ISelectFormatoController selectFormatoController)
    {
        _selectFormatoController = selectFormatoController;
    }
    
    [HttpGet("/select-formatos")]
    [ProducesResponseType(typeof(SelectFormatoViewModel), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SelectFormatoViewModel>>> SelectFormato() 
        => Ok(await _selectFormatoController.Handle());
}

