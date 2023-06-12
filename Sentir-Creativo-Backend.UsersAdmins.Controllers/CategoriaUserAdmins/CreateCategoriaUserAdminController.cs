using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaUserAdmins.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.CategoriaUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.CategoriaUserAdmins;

public class CreateCategoriaUserAdminController : ICreateCategoriaUserAdminController
{
    private readonly ICreateCategoriaUserAdminInputPort _inputPort;
    private readonly ICreateCategoriaUserAdminPresenter _presenter;
    
    public CreateCategoriaUserAdminController(
        ICreateCategoriaUserAdminInputPort inputPort, 
        ICreateCategoriaUserAdminPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    
    public async ValueTask<int> Handle(CreateCategoriaUserAdminDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.CategoriaId;
    }
}