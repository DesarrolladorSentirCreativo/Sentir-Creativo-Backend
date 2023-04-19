using System.Net;
using Microsoft.AspNetCore.Mvc;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.WebApi.Controllers;

[ApiController]
[Route("api/v1/userAdmin")]
public class UserAdminWrapperController : ControllerBase
{
    private readonly ILoginUserAdminController _loginUserAdminController;
    
    public UserAdminWrapperController(ILoginUserAdminController loginUserAdminController)
    {
        _loginUserAdminController = loginUserAdminController;
    }
    
    [HttpPost(Name = "LoginUserAdmin")]
    [ProducesResponseType(typeof(UserAdminTokenViewModel),(int)HttpStatusCode.OK)]
    public async Task<ActionResult<UserAdminTokenViewModel>> CreateAudiencia([FromBody] LoginUserAdminDto dto)
        => Ok(await _loginUserAdminController.Handle(dto));
}