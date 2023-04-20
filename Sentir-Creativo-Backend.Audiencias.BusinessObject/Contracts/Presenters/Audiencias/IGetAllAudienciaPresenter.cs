using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.GetAll;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Audiencias;

public interface IGetAllAudienciaPresenter : IGetAllAudienciaOutputPort
{
    IReadOnlyList<GetAllAudienciaViewModel> List { get; }
}