using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.TecnicaArtisticas;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Dtos.TecnicaArtisticas;
using System.Net;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Servicios
{
    [Authorize]
    [ApiController]
    [Route("api/v1/tecnicas-artisticas")]
    public class TecnicaArtisticaWrapperController : ControllerBase
    {
        private readonly ICreateTecnicaArtisticaController _createTecnicaArtisticaController;
        private readonly IUpdateTecnicaArtisticaController _updateTecnicaArtisticaController;

        public TecnicaArtisticaWrapperController(
            ICreateTecnicaArtisticaController createTecnicaArtisticaController,
            IUpdateTecnicaArtisticaController updateTecnicaArtisticaController)
        {
            _createTecnicaArtisticaController = createTecnicaArtisticaController;
            _updateTecnicaArtisticaController = updateTecnicaArtisticaController;
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateTecnicaArtistica([FromBody] CreateTecnicaArtisticaDto dto)
        => Ok(await _createTecnicaArtisticaController.Handle(dto));

        [HttpPut]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateTecnicaArtistica([FromBody] UpdateTecnicaArtisticaDto dto)
            => Ok(await _updateTecnicaArtisticaController.Handle(dto));
    }
}
