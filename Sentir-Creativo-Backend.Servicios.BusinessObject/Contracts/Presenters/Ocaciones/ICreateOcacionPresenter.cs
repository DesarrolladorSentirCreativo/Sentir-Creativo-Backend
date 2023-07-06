using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Ocacions.Create;
namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.Ocacions
{
    public  interface ICreateOcacionPresenter : ICreateOcacionOutputPort
    {
        int OcacionId { get; }
    }
}
