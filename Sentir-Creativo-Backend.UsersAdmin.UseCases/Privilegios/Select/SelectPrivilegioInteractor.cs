namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Privilegios.Select;

public class SelectPrivilegioInteractor : ISelectPrivilegioInputPort
{
    private readonly IReadRepository<Privilegio,string> _readRepository;
    private readonly ISelectPrivilegioOutputPort _outputPort;

    public SelectPrivilegioInteractor(IReadRepository<Privilegio, string> readRepository,
        ISelectPrivilegioOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new PrivilegioActivosSpecification();

        var privilegios = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectPrivilegioViewModel> data = privilegios
            .Select(p => 
                new SelectPrivilegioViewModel()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                })
            .ToList()
            .AsReadOnly();

        await _outputPort.Handle(data);
    }
}