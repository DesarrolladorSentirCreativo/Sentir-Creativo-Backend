using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;
using Sentir_Creativo_Backend.SharedKernel.Entities.ViewModels;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Audiencias;

[Authorize]
[ApiController]
[Route("api/v1/audiencias")]
public class AudienciaWrapperController : ControllerBase
{
    private readonly ICreateAudienciaController _createAudienciaController;
    private readonly IPaginationAudienciaController _paginationAudienciaController;
    private readonly IUpdateAudienciaController _updateAudienciaController;
    private readonly ISearchAudienciasDifusionController _searchAudienciasDifusionController;
    private readonly IGetByIdAudienciaController _getByIdAudienciaController;
    private readonly IGetAllAudienciaController _getAllAudienciaController;
    private readonly IDeleteAudienciaController _deleteAudienciaController;

    public AudienciaWrapperController(ICreateAudienciaController createAudienciaController,
        IPaginationAudienciaController paginationAudienciaController,
        IUpdateAudienciaController updateAudienciaController,
        ISearchAudienciasDifusionController searchAudienciasDifusionController,
        IGetByIdAudienciaController getByIdAudienciaController,
        IGetAllAudienciaController getAllAudienciaController,
        IDeleteAudienciaController deleteAudienciaController)
    {
        _createAudienciaController = createAudienciaController;
        _paginationAudienciaController = paginationAudienciaController;
        _updateAudienciaController = updateAudienciaController;
        _searchAudienciasDifusionController = searchAudienciasDifusionController;
        _getByIdAudienciaController = getByIdAudienciaController;
        _getAllAudienciaController = getAllAudienciaController;
        _deleteAudienciaController = deleteAudienciaController;
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
    
    [HttpGet("all")]
    [ProducesResponseType(typeof(IReadOnlyList<GetAllAudienciaViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<GetAllAudienciaViewModel>>> GetAllAudiencia()
        => Ok(await _getAllAudienciaController.Handle());
    

    [HttpPut(Name = "UpdateAudiencia")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> UpdateAudiencia([FromBody] UpdateAudienciaDto dto)
     => Ok(await _updateAudienciaController.Handle(dto));
    

    [HttpGet("difusion/{id}")]
    [ProducesResponseType(typeof(IReadOnlyList<SearchAudienciasDifusionViewModel>), (int)HttpStatusCode.OK)]
    public async Task<ActionResult<IReadOnlyList<SearchAudienciasDifusionViewModel>>> SearchAudienciasDifusion(int id)
        => Ok(await _searchAudienciasDifusionController.Handle(id));
    

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(GetByIdAudienciaViewModel),(int)HttpStatusCode.OK)]
    public async Task<ActionResult<GetByIdAudienciaViewModel>> GetByIdAudiencia(int id)
         =>Ok(await _getByIdAudienciaController.Handle(id));

    [HttpPut("{id}")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    public async Task<ActionResult<int>> DeleteAudiencia(int id)
        => Ok(await _deleteAudienciaController.Handle(id));
}