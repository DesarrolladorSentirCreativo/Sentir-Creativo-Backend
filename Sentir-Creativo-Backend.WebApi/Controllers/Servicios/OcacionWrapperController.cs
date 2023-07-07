namespace Sentir_Creativo_Backend.WebApi.Controllers.Servicios
{
    [Authorize]
    [ApiController]
    [Route("api/v1/ocaciones")]
    public class OcacionWrapperController : ControllerBase

    {
        private readonly ICreateOcacionController _createOcacionController;
        private readonly IUpdateOcacionController   _updateOcacionController;
        private readonly IDeleteOcacionController _deleteOcacionController;
        private readonly IGetAllOcacionController _getAllOcacionController;
        private readonly ISelectOcacionController _selectOcacionController;

        public OcacionWrapperController(
        ICreateOcacionController createOcacionController,
        IUpdateOcacionController updateOcacionController,
        IDeleteOcacionController deleteOcacionController,
        IGetAllOcacionController getAllOcacionController,
        ISelectOcacionController selectOcacionController)
        {
            _createOcacionController = createOcacionController;
            _updateOcacionController = updateOcacionController;
            _deleteOcacionController = deleteOcacionController;
            _getAllOcacionController = getAllOcacionController;
            _selectOcacionController = selectOcacionController;
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateOcacion([FromBody] CreateOcacionDto dto)
        => Ok(await _createOcacionController.Handle(dto));


        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateOcacion([FromBody] UpdateOcacionDto dto)
            => Ok(await _updateOcacionController.Handle(dto));

        [HttpPut("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> DeleteOcacion(int id)
       => Ok(await _deleteOcacionController.Handle(id));


        [HttpGet]
        [ProducesResponseType(typeof(IReadOnlyList<GetAllOcacionViewModel>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IReadOnlyList<GetAllOcacionViewModel>>> GetAllOcacion()
            => Ok(await _getAllOcacionController.Handle());


        [HttpGet]
        [Route("select")]
        [ProducesResponseType(typeof(SelectOcacionModelView), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IReadOnlyList<SelectOcacionModelView>>> SelectOcacion()
            => Ok(await _selectOcacionController.Handle());


    }
}
