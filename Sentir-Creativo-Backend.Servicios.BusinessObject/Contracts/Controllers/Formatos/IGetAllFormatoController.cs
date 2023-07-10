namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.Formatos
{
    public interface IGetAllFormatoController 
    {
        ValueTask<IReadOnlyList<GetAllFormatoViewModel>> Handle();
    }
}
