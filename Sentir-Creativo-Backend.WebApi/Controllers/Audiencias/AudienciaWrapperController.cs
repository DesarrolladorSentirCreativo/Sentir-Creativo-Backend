using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;
using Sentir_Creativo_Backend.SharedKernel.Entities.ViewModels;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Audiencias;

[ApiController]
[Route("api/v1/audiencias")]
public class AudienciaWrapperController : ControllerBase
{
    private readonly ICreateAudienciaController _createAudienciaController;
    private readonly IPaginationAudienciaController _paginationAudienciaController;
    private readonly IUpdateAudienciaController _updateAudienciaController;
    private readonly ISearchAudienciasDifusionController _searchAudienciasDifusionController;
    private readonly IGetByIdAudienciaController _getByIdAudienciaController;

    public AudienciaWrapperController(ICreateAudienciaController createAudienciaController,
        IPaginationAudienciaController paginationAudienciaController,
        IUpdateAudienciaController updateAudienciaController,
        ISearchAudienciasDifusionController searchAudienciasDifusionController,
        IGetByIdAudienciaController getByIdAudienciaController)
    {
        _createAudienciaController = createAudienciaController;
        _paginationAudienciaController = paginationAudienciaController;
        _updateAudienciaController = updateAudienciaController;
        _searchAudienciasDifusionController = searchAudienciasDifusionController;
        _getByIdAudienciaController = getByIdAudienciaController;
    }

    [HttpPost(Name = "CreateAudiencia")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> CreateAudiencia([FromBody] CreateAudienciaDto dto)
         => Ok(await _createAudienciaController.Handle(dto));

    [HttpGet]
    [ProducesResponseType(typeof(PaginationViewModel<AudienciaWithRelationsViewModels>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<PaginationViewModel<AudienciaWithRelationsViewModels>>> GetPaginationAudiencia(
        [FromQuery] AudienciaPaginationDto dto)
        => Ok(await _paginationAudienciaController.Handle(dto));
    

    [HttpPut(Name = "UpdateAudiencia")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> UpdateAudiencia([FromBody] UpdateAudienciaDto dto)
     => Ok(await _updateAudienciaController.Handle(dto));
    

    [HttpGet("/difusion/{id}")]
    [ProducesResponseType(typeof(IReadOnlyList<SearchAudienciasDifusionViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SearchAudienciasDifusionViewModel>>> SearchAudienciasDifusion(int id)
        => Ok(await _searchAudienciasDifusionController.Handle(id));
    

    [HttpGet("/{id}")]
    [ProducesResponseType(typeof(GetByIdAudienciaViewModel),(int)HttpStatusCode.OK)]
    public async Task<ActionResult<GetByIdAudienciaViewModel>> GetByIdAudiencia(int id)
         =>Ok(await _getByIdAudienciaController.Handle(id));
}