using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaUserAdmins.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.CategoriaUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.CategoriaUserAdmins;

public class GetByIdCategoriaUserAdminController : IGetByIdCategoriaUserAdminController
{
    private readonly IGetByIdCategoriaUserAdminInputPort _inputPort;
    private readonly IGetByIdCategoriaUserAdminPresenter _presenter;
    
    public GetByIdCategoriaUserAdminController(
        IGetByIdCategoriaUserAdminInputPort inputPort, 
        IGetByIdCategoriaUserAdminPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    public async ValueTask<GetByIdCategoriaUserAdminViewModel> Handle(int categoriaId)
    {
        await _inputPort.Handle(categoriaId);
        return _presenter.ViewModel;
    }
}