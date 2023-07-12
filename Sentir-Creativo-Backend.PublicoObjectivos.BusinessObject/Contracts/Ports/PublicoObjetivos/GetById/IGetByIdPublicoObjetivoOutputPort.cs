namespace Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Ports.PublicoObjetivos.GetById
{
    public interface IGetByIdPublicoObjetivoOutputPort
    {
        ValueTask Handle(GetByIdPublicoObjetivoViewModel viewModel);
    }

}
