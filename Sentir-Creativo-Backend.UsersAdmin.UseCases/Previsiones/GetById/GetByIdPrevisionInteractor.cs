namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Previsiones.GetById;

public class GetByIdPrevisionInteractor : IGetByIdPrevisionInputPort
{
    private readonly IReadRepository<Prevision,int> _readRepository;
    private readonly IGetByIdPrevisionOutputPort _outputPort;
    
    public GetByIdPrevisionInteractor(
        IReadRepository<Prevision, int> readRepository,
        IGetByIdPrevisionOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle(int previsionId)
    {
        var spec = new PrevisionActivoByIdSpecification(previsionId);

        var prevision = await _readRepository.GetByIdWithSpec(spec);

        if (prevision == null) throw new NotFoundException("El prevision no se encuentra registrado");

        var data = new GetByIdPrevisionViewModel()
        {
            Id = prevision.Id,
            Nombre = prevision.Nombre,
            Descripcion = prevision.Descripcion,
        };

        await _outputPort.Handle(data);
    }
}