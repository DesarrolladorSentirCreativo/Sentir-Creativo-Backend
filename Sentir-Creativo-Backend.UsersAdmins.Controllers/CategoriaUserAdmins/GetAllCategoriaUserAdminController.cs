using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaUserAdmins.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.CategoriaUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.CategoriaUserAdmins;

public class GetAllCategoriaUserAdminController : IGetAllCategoriaUserAdminController
{
    private readonly IGetAllCategoriaUserAdminInputPort _inputPort;
    private readonly IGetAllCategoriaUserAdminPresenter _presenter;
    
    public GetAllCategoriaUserAdminController(
        IGetAllCategoriaUserAdminInputPort inputPort, 
        IGetAllCategoriaUserAdminPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    
    public async ValueTask<IReadOnlyList<GetAllCategoriaUserAdminViewModel>> Handle()
    {
        await _inputPort.Handle();
        return _presenter.ModelViews;
    }
}