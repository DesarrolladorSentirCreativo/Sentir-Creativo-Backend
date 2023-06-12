using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.CategoriaUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaUserAdmins.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaUserAdmins;

namespace Sentir_Creativo_Backend.UsersAdmins.Controllers.CategoriaUserAdmins;

public class DeleteCategoriaUserAdminController : IDeleteCategoriaUserAdminController
{
    private readonly IDeleteCategoriaUserAdminInputPort _inputPort;
    private readonly IDeleteCategoriaUserAdminPresenter _presenter;
    
    public DeleteCategoriaUserAdminController(
        IDeleteCategoriaUserAdminInputPort inputPort, 
        IDeleteCategoriaUserAdminPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    
    public async ValueTask<int> Handle(int categoriaId)
    {
        await _inputPort.Handle(categoriaId);
        return _presenter.CategoriaId;
    }
}