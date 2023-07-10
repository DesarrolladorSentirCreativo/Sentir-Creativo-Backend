namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.Formatos
{
    public interface ICreateFormatoController 
    {
        ValueTask<int> Handle(CreateFormatoDto dto);
    }
}
