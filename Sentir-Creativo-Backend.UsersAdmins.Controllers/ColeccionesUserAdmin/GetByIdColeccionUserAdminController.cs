using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.ColeccionesUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.ColeccionesUserAdmin;

public class GetByIdColeccionUserAdminController : IGetByIdColeccionUserAdminController
{
    private readonly IGetByIdColeccionUserAdminInputPort _inputPort;
    private readonly IGetByIdColeccionUserAdminPresenter _presenter;

    public GetByIdColeccionUserAdminController(IGetByIdColeccionUserAdminInputPort inputPort,
        IGetByIdColeccionUserAdminPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async  ValueTask<GetByIdColeccionUserAdminViewModel> Handle(int coleccionUserAdminId)
    {
        await _inputPort.Handle(coleccionUserAdminId);
        return _presenter.GetByIdColeccionUserAdminViewModel;
    }
}