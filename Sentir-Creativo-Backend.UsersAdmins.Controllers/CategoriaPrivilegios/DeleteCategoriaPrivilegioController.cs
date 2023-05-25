using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaPrivilegios;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.CategoriaPrivilegios;

public class DeleteCategoriaPrivilegioController : IDeleteCategoriaPrivilegioController
{
    private readonly IDeleteCategoriaPrivilegioInputPort _inputPort;
    private readonly IDeleteCategoriaPrivilegioPresenter  _presenter;

    public DeleteCategoriaPrivilegioController(
        IDeleteCategoriaPrivilegioInputPort inputPort,
        IDeleteCategoriaPrivilegioPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }

    public async ValueTask<int> Handle(int categoriaPrivilegioId)
    {
        await _inputPort.Handle(categoriaPrivilegioId);
        return _presenter.CategoriaPrivilegioId;
    }
}