namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.AFP.Select;

public class SelectAfpInteractor : ISelectAfpInputPort
{
    private readonly IReadRepository<Afp,int> _readRepository;
    private readonly ISelectAfpOutputPort _outputPort;
    
    public SelectAfpInteractor(IReadRepository<Afp, int> readRepository,
        ISelectAfpOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new AfpActivosSpecification();

        var afp = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectAfpViewModel> data = afp
            .Select(p => 
                new SelectAfpViewModel()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,

                })
            .ToList()
            .AsReadOnly();

        await _outputPort.Handle(data);
    }
}