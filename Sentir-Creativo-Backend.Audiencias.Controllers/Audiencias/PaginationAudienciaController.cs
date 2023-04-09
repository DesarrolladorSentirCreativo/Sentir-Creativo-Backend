using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.Pagination;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;
using Sentir_Creativo_Backend.SharedKernel.Entities.ViewModels;

namespace Sentir_Creativo_Backend.Audiencias.Controllers.Audiencias;

public class PaginationAudienciaController : IPaginationAudienciaController
{
    private readonly IPaginationAudienciaInputPort _inputPort;
    private readonly IPaginationAudienciaPresenter _presenter;

    public PaginationAudienciaController(IPaginationAudienciaInputPort inputPort, IPaginationAudienciaPresenter presenter)
    {
        _inputPort = inputPort;
        _presenter = presenter;
    }
    
    
    public async ValueTask<PaginationViewModel<AudienciaWithRelationsViewModels>> Handle(AudienciaPaginationDto dto)
    {
        await _inputPort.Handle(dto);
        return _presenter.PaginationAudiencia;
    }
}