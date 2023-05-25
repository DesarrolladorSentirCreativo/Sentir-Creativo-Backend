using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.CategoriaPrivilegios;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.CategoriaPrivilegios;

public class UpdateCategoriaPrivilegioController : IUpdateCategoriaPrivilegioController
{
    private readonly IUpdateCategoriaPrivilegioInputPort _inputPort;
    private readonly IUpdateCategoriaPrivilegioPresenter  _presenter;

    public UpdateCategoriaPrivilegioController(
        IUpdateCategoriaPrivilegioInputPort inputPort,
        IUpdateCategoriaPrivilegioPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }

    public async ValueTask<int> Handle(UpdateCategoriaPrivilegioDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.CategoriaPrivilegioId;
    }
}