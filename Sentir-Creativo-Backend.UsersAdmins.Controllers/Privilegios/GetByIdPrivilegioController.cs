using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Privilegios;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.Privilegios;

public class GetByIdPrivilegioController : IGetByIdPrivilegioController
{
    private readonly IGetByIdPrivilegioInputPort _inputPort;
    private readonly IGetByIdPrivilegioPresenter  _presenter;
    
    public GetByIdPrivilegioController(
        IGetByIdPrivilegioInputPort inputPort,
        IGetByIdPrivilegioPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<GetByIdPrivilegioViewModel> Handle(string privilegioId)
    {
        await _inputPort.Handle(privilegioId);
        return _presenter.ModelView;
    }
}