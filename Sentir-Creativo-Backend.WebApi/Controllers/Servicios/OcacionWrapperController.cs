using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.Ocacions;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Dtos.Ocacions;
using System.Net;

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

        public OcacionWrapperController(
        ICreateOcacionController createOcacionController,
        IUpdateOcacionController updateOcacionController,
        IDeleteOcacionController deleteOcacionController)
        {
            _createOcacionController = createOcacionController;
            _updateOcacionController = updateOcacionController;
            _deleteOcacionController = deleteOcacionController;
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


    }
}
