using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.CategoriaPrivilegios;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.CategoriaPrivilegios;

public class SelectCategoriaPrivilegioController : ISelectCategoriaPrivilegioController
{
    private readonly ISelectCategoriaPrivilegioInputPort _inputPort;
    private readonly ISelectCategoriaPrivilegioPresenter  _presenter;
    
    public SelectCategoriaPrivilegioController(ISelectCategoriaPrivilegioInputPort inputPort,
        ISelectCategoriaPrivilegioPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<IReadOnlyList<SelectCategoriaPrivilegioViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.ModelViews;
    }
}