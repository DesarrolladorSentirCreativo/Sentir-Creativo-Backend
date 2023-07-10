namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.Formatos
{
    public interface IUpdateFormatoController
    {
        ValueTask<int> Handle(UpdateFormatoDto dto);
    }
}
