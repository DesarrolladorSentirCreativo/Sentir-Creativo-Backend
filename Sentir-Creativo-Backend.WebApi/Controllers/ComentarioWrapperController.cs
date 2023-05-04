using System.Net;
using Microsoft.AspNetCore.Mvc;
using Senitr_Creativo_Backend.Comentarios.Entities.DTO;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Controllers;

namespace Sentir_Creativo_Backend.WebApi.Controllers;

[ApiController]
[Route("api/v1/comentarios")]
public class ComentarioWrapperController : ControllerBase
{
    private readonly ICreateComentarioController _createComentarioController;
    
    public ComentarioWrapperController(ICreateComentarioController createComentarioController)
    {
        _createComentarioController = createComentarioController;
    }
    
    [HttpPost(Name = "CreateComentario")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateComentario([FromBody] CreateComentarioDto dto)
        => Ok(await _createComentarioController.Handle(dto));
}