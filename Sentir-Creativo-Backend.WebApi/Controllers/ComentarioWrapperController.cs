using System.Net;
using Microsoft.AspNetCore.Mvc;
using Senitr_Creativo_Backend.Comentarios.Entities.DTO;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Controllers;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.ViewModels;

namespace Sentir_Creativo_Backend.WebApi.Controllers;

[ApiController]
[Route("api/v1/comentarios")]
public class ComentarioWrapperController : ControllerBase
{
    private readonly ICreateComentarioController _createComentarioController;
    private readonly IGetByIdComentarioController _getByIdComentarioController;
    
    public ComentarioWrapperController(
        ICreateComentarioController createComentarioController,
        IGetByIdComentarioController getByIdComentarioController)
    {
        _createComentarioController = createComentarioController;
        _getByIdComentarioController = getByIdComentarioController;
    }
    
    [HttpPost(Name = "CreateComentario")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateComentario([FromBody] CreateComentarioDto dto)
        => Ok(await _createComentarioController.Handle(dto));
    
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(GetByIdComentarioViewModel),(int)HttpStatusCode.OK)]
    public async Task<ActionResult<GetByIdComentarioViewModel>> GetByIdComentario(int id)
        =>Ok(await _getByIdComentarioController.Handle(id));
}