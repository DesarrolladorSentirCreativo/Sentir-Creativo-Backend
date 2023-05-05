using System.Net;
using Microsoft.AspNetCore.Mvc;
using Senitr_Creativo_Backend.Comentarios.Entities.DTO;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Controllers;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.DTO;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.ViewModels;

namespace Sentir_Creativo_Backend.WebApi.Controllers;

[ApiController]
[Route("api/v1/comentarios")]
public class ComentarioWrapperController : ControllerBase
{
    private readonly ICreateComentarioController _createComentarioController;
    private readonly IGetByIdComentarioController _getByIdComentarioController;
    private readonly IUpdateComentarioController _updateComentarioController;
    private readonly IDeleteComentarioController _deleteComentarioController;
    
    public ComentarioWrapperController(
        ICreateComentarioController createComentarioController,
        IGetByIdComentarioController getByIdComentarioController,
        IUpdateComentarioController updateComentarioController,
        IDeleteComentarioController deleteComentarioController)
    {
        _createComentarioController = createComentarioController;
        _getByIdComentarioController = getByIdComentarioController;
        _updateComentarioController = updateComentarioController;
        _deleteComentarioController = deleteComentarioController;
    }
    
    [HttpPost(Name = "CreateComentario")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateComentario([FromBody] CreateComentarioDto dto)
        => Ok(await _createComentarioController.Handle(dto));
    
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(GetByIdComentarioViewModel),(int)HttpStatusCode.OK)]
    public async Task<ActionResult<GetByIdComentarioViewModel>> GetByIdComentario(int id)
        =>Ok(await _getByIdComentarioController.Handle(id));
    
    [HttpPut(Name = "UpdateComentario")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> UpdateComentario([FromBody] UpdateComentarioDto dto)
        => Ok(await _updateComentarioController.Handle(dto));
    
    [HttpDelete("{id}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> DeleteComentario(int id)
        => Ok(await _deleteComentarioController.Handle(id));
}