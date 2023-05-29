using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Modulos;

namespace Sentir_Creativo_Backend.UsersAdmins.Presenters.Modulos;

public class CreateModuloPresenter : ICreateModuloPresenter
{
    public int ModuloId { get; private set; }
    
    public ValueTask Handle(int moduloId)
    {
        ModuloId = moduloId;
        
        return ValueTask.CompletedTask;
    }
    
}