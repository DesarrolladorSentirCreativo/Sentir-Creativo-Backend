namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.EstadoUserAdmins.Select;

public class SelectEstadoUserAdminInteractor : ISelectEstadoUserAdminInputPort
{
    private readonly ISelectEstadoUserAdminOutputPort _outputPort;
    private readonly IReadRepository<EstadoUserAdmin, int> _readRepository;
    
    public SelectEstadoUserAdminInteractor(
        ISelectEstadoUserAdminOutputPort outputPort, 
        IReadRepository<EstadoUserAdmin, int> readRepository)
    {
        _outputPort = outputPort;
        _readRepository = readRepository;
    }
    
    public async ValueTask Handle()
    {
        var spec = new EstadoUserAdminActivosSpecification();

        var estadosUserAdmins = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectEstadoUserAdminViewModel> data = estadosUserAdmins
            .Select(p => 
                new SelectEstadoUserAdminViewModel()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,

                })
            .ToList()
            .AsReadOnly();

        await _outputPort.Handle(data);
    }
}