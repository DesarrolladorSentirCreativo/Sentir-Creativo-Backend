namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.ModoTrabajos.GetAll;

public class GetAllModoTrabajoInteractor : IGetAllModoTrabajoInputPort
{
    private readonly IReadRepository<ModoTrabajo,int> _readRepository;
    private readonly IGetAllModoTrabajoOutputPort _outputPort;
    
    public GetAllModoTrabajoInteractor(IReadRepository<ModoTrabajo, int> readRepository,
        IGetAllModoTrabajoOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async  ValueTask Handle()
    {
        var spec = new ModoTrabajoActivosSpecification();

        var modoTrabajos = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<GetAllModoTrabajoViewModel> data = modoTrabajos
            .Select(p => 
                new GetAllModoTrabajoViewModel()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    Descripcion = p.Descripcion,

                })
            .ToList()
            .AsReadOnly();

        await _outputPort.Handle(data);
    }
}