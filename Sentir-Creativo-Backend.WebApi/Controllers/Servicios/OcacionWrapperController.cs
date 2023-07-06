using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.Ocacions;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Dtos.Ocacions;
using System.Net;

namespace Sentir_Creativo_Backend.WebApi.Controllers.Servicios
{
    [Authorize]
    [ApiController]
    [Route("api/v1/ocacions")]
    public class OcacionWrapperController : ControllerBase

    {
        private  readonly ICreateOcacionController _createOcacionController;

        public OcacionWrapperController(
        ICreateOcacionController createOcacionController)
        {
          _createOcacionController = createOcacionController;

        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateOcacion([FromBody] CreateOcacionDto dto)
        => Ok(await _createOcacionController.Handle(dto));
    }
}
