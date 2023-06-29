namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.UsuarioAdmins.Select;

public class SelectUsuarioAdminInteractor : ISelectUsuarioAdminInputPort
{
    private readonly IReadRepository<UsuarioAdmin,int> _usuarioAdminReadRepository;
    private readonly ISelectUsuarioAdminOutputPort _outputPort;
    
    public SelectUsuarioAdminInteractor(
        IReadRepository<UsuarioAdmin,int> usuarioAdminReadRepository,
        ISelectUsuarioAdminOutputPort outputPort)
    {
        _usuarioAdminReadRepository = usuarioAdminReadRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new UsuarioAdminActivosSpecification();
        
        var usuarios = await _usuarioAdminReadRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectUsuarioAdminViewModel> data = usuarios
            .Select(p => 
                new SelectUsuarioAdminViewModel() 
                { 
                    Id = p.Id,
                    Nombre =  p.NumDocumento + " | " +  p.Nombre + " " + p.Apellidos
                })
            .ToList()
            .AsReadOnly();
        
        await _outputPort.Handle(data);
    }
}