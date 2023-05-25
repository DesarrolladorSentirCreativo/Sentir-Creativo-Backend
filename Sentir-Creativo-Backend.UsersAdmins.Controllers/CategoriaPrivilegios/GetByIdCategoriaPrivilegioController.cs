using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.CategoriaPrivilegios;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.CategoriaPrivilegios;

public class GetByIdCategoriaPrivilegioController : IGetByIdCategoriaPrivilegioController
{
    private readonly IGetByIdCategoriaPrivilegioInputPort _inputPort;
    private readonly IGetByIdCategoriaPrivilegioPresenter  _presenter;

    public GetByIdCategoriaPrivilegioController(
        IGetByIdCategoriaPrivilegioInputPort inputPort,
        IGetByIdCategoriaPrivilegioPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }

    public async ValueTask<GetByIdCategoriaPrivilegioViewModel> Handle(int categoriaPrivilegioId)
    {
        await _inputPort.Handle(categoriaPrivilegioId);
        return _presenter.ModelView;
    }
}