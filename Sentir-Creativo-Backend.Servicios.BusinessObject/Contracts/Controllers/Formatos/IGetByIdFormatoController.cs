namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.Formatos
{
    public interface IGetByIdFormatoController 
    {
        ValueTask<GetByIdFormatoViewModel> Handle(int formatoId);
    }
}
