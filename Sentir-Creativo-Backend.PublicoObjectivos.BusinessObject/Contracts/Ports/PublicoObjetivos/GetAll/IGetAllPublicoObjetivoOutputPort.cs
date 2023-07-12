namespace Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Ports.PublicoObjetivos.GetAll
{
    public interface IGetAllPublicoObjetivoOutputPort
    {
        ValueTask Handle(IReadOnlyList<GetAllPublicoObjetivoViewModel> viewModels);
    }
}
