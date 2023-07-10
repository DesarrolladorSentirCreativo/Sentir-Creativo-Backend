namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.EstadoServicios
{
    public interface IDeleteEstadoServicioController 
    {
        ValueTask<int> Handle(int estadoServicioId);
    }
}
