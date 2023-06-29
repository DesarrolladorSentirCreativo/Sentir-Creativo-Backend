namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Previsiones.GetAll;

public class GetAllPrevisionInteractor : IGetAllPrevisionInputPort
{
    private readonly IReadRepository<Prevision,int> _readRepository;
    private readonly IGetAllPrevisionOutputPort _outputPort;

    public GetAllPrevisionInteractor(
        IReadRepository<Prevision, int> readRepository,
        IGetAllPrevisionOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new PrevisionActivosSpecification();

        var afp = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<GetAllPrevisionViewModel> data = afp
            .Select(p => 
                new GetAllPrevisionViewModel()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    Descripcion = p.Descripcion

                })
            .ToList()
            .AsReadOnly();

        await _outputPort.Handle(data);
    }
}