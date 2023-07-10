namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.Formatos
{
    public interface IDeleteFormatoController
    {
        ValueTask<int> Handle(int formatoId);
    }
}
