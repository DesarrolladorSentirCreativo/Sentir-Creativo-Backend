using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaUserAdmins.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.CategoriaUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.CategoriaUserAdmins;

public class SelectCategoriaUserAdminController : ISelectCategoriaUserAdminController
{
    private readonly ISelectCategoriaUserAdminInputPort _inputPort;
    private readonly ISelectCategoriaUserAdminPresenter _presenter;
    
    public SelectCategoriaUserAdminController(
        ISelectCategoriaUserAdminInputPort inputPort, 
        ISelectCategoriaUserAdminPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async  ValueTask<IReadOnlyList<SelectCategoriaUserAdminViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.ViewModels;
    }
}