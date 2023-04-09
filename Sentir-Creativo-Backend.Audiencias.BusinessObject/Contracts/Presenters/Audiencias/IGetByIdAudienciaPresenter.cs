using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.GetById;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Audiencias;

public interface IGetByIdAudienciaPresenter : IGetByIdAudienciaOutputPort
{
    GetByIdAudienciaViewModel GetByIdAudenciaViewModel { get; }
}