using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.CategoriaPrivilegios;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.CategoriaPrivilegios;

public class CreateCategoryPrivilegioController : ICreateCategoriaPrivilegioController
{
    private readonly ICreateCategoriaPrivilegioInputPort _inputPort;
    private readonly ICreateCategoriaPrivilegioPresenter  _presenter;

    public CreateCategoryPrivilegioController(
        ICreateCategoriaPrivilegioInputPort inputPort,
        ICreateCategoriaPrivilegioPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }

    public async ValueTask<int> Handle(CreateCategoriaPrivilegioDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.CategoriaPrivilegioId;
    }
}