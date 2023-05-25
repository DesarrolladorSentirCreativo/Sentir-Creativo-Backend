using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.CategoriaPrivilegios;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.CategoriaPrivilegios;

public class GetAllCategoriaPrivilegioController : IGetAllCategoriaPrivilegioController
{
    private readonly IGetAllCategoriaPrivilegioInputPort _inputPort;
    private readonly IGetAllCategoriaPrivilegioPresenter  _presenter;

    public GetAllCategoriaPrivilegioController(
        IGetAllCategoriaPrivilegioInputPort inputPort,
        IGetAllCategoriaPrivilegioPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }

    public async ValueTask<IReadOnlyList<GetAllCategoriaPrivilegioViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.ModelViews;
    }
}