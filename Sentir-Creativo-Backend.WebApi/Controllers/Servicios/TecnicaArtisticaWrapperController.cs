using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.TecnicaArtisticas;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Dtos.TecnicaArtisticas;
using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.TecnicaArtistica;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Privilegios;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Servicios
{
    [Authorize]
    [ApiController]
    [Route("api/v1/tecnicas-artisticas")]
    public class TecnicaArtisticaWrapperController : ControllerBase
    {
        private readonly ICreateTecnicaArtisticaController _createTecnicaArtisticaController;
        private readonly IUpdateTecnicaArtisticaController _updateTecnicaArtisticaController;
        private readonly IDeleteTecnicaArtisitcaController _deleteTecnicaArtisitcaController;
        private readonly IGetByIdTecnicaArtisticaController _getByIdTecnicaArtisticaController;
        private readonly IGetAllTecnicaArtisticaController _getAllTecnicaArtisticaController;
        private readonly ISelectTecnicaArtisticaController _selectTecnicaArtisticaController;

        public TecnicaArtisticaWrapperController(
            ICreateTecnicaArtisticaController createTecnicaArtisticaController,
            IUpdateTecnicaArtisticaController updateTecnicaArtisticaController,
            IDeleteTecnicaArtisitcaController deleteTecnicaArtisitcaController,
            IGetByIdTecnicaArtisticaController getByIdTecnicaArtisticaController,
            IGetAllTecnicaArtisticaController getAllTecnicaArtisticaController,
            ISelectTecnicaArtisticaController selectTecnicaArtisticaController)
        {
            _createTecnicaArtisticaController = createTecnicaArtisticaController;
            _updateTecnicaArtisticaController = updateTecnicaArtisticaController;
            _deleteTecnicaArtisitcaController = deleteTecnicaArtisitcaController;
            _getByIdTecnicaArtisticaController = getByIdTecnicaArtisticaController;
            _getAllTecnicaArtisticaController = getAllTecnicaArtisticaController;
            _selectTecnicaArtisticaController = selectTecnicaArtisticaController;
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateTecnicaArtistica([FromBody] CreateTecnicaArtisticaDto dto)
        => Ok(await _createTecnicaArtisticaController.Handle(dto));

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateTecnicaArtistica([FromBody] UpdateTecnicaArtisticaDto dto)
            => Ok(await _updateTecnicaArtisticaController.Handle(dto));

        [HttpPut("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> DeleteTecnicaArtistica(int id)
            => Ok(await _deleteTecnicaArtisitcaController.Handle(id));

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(GetByIdTecnicaArtisticaViewModel), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<GetByIdPrivilegioViewModel>> GetByIdTecnicaArtistica(int id)
       => Ok(await _getByIdTecnicaArtisticaController.Handle(id));

        [HttpGet]
        [ProducesResponseType(typeof(IReadOnlyList<GetAllTecnicaArtisticaViewModel>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IReadOnlyList<GetAllTecnicaArtisticaViewModel>>> GetAllTecnicaArtistica()
        => Ok(await _getAllTecnicaArtisticaController.Handle());

        [HttpGet]
        [Route("select")]
        [ProducesResponseType(typeof(SelectTecnicaArtisticaViewModel), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IReadOnlyList<SelectTecnicaArtisticaViewModel>>> SelectTecnicaArtistica()
        => Ok(await _selectTecnicaArtisticaController.Handle());

    }
}
