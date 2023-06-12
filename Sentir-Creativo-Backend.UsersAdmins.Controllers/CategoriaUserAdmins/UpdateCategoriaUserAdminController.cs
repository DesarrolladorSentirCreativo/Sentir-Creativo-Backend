using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaUserAdmins.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.CategoriaUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.CategoriaUserAdmins;

public class UpdateCategoriaUserAdminController : IUpdateCategoriaUserAdminController
{
    private readonly IUpdateCategoriaUserAdminInputPort _inputPort;
    private readonly IUpdateCategoriaUserAdminPresenter _presenter;
    
    public UpdateCategoriaUserAdminController(
        IUpdateCategoriaUserAdminInputPort inputPort, 
        IUpdateCategoriaUserAdminPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<int> Handle(UpdateCategoriaUserAdminDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.CategoriaId;
    }
}