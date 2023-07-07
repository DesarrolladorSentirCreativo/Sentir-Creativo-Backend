namespace Sentir_Creativo_Backend.Servicios.Presenters.EstadoServicios;

public class SelectEstadoServicioPresenter : ISelectEstadoServicioPresenter
{
    public IReadOnlyList<SelectEstadoServicioViewModel> SelectEstadoServicioViewModel { get; private set; }
    
    public ValueTask Handle(IReadOnlyList<SelectEstadoServicioViewModel> modelView)
    {
        SelectEstadoServicioViewModel = modelView;
        
        return ValueTask.CompletedTask;
    }
    
}