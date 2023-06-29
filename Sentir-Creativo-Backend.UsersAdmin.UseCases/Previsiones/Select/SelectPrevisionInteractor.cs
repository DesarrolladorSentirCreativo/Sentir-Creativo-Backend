namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Previsiones.Select;

public class SelectPrevisionInteractor : ISelectPrevisionInputPort
{
    private readonly IReadRepository<Prevision,int> _readRepository;
    private readonly ISelectPrevisionOutputPort _outputPort;
    
    public SelectPrevisionInteractor(
        IReadRepository<Prevision, int> readRepository,
        ISelectPrevisionOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new PrevisionActivosSpecification();

        var afp = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectPrevisionViewModel> data = afp
            .Select(p => 
                new SelectPrevisionViewModel()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,

                })
            .ToList()
            .AsReadOnly();

        await _outputPort.Handle(data);
    }
}