namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.ModoTrabajos.GetById;

public class GetByIdModoTrabajoInteractor : IGetByIdModoTrabajoInputPort
{
    private readonly IReadRepository<ModoTrabajo,int> _readRepository;
    private readonly IGetByIdModoTrabajoOutputPort _outputPort;
    
    public GetByIdModoTrabajoInteractor(IReadRepository<ModoTrabajo, int> readRepository,
        IGetByIdModoTrabajoOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle(int modoTrabajoId)
    {
        var spec = new ModoTrabajoActivoByIdSpecification(modoTrabajoId);

        var modoTrabajo = await _readRepository.GetByIdWithSpec(spec);

        if (modoTrabajo == null) throw new NotFoundException("El modo de trabajo no se encuentra registrada");
    

        var data = new GetByIdModoTrabajoViewModel()
        {
            Id = modoTrabajo.Id,
            Nombre = modoTrabajo.Nombre,
            Descripcion = modoTrabajo.Descripcion,

        };
        
        await _outputPort.Handle(data);
    }
}