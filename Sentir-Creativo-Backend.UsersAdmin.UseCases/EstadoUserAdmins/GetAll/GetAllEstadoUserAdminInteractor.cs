namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.EstadoUserAdmins.GetAll;

public class GetAllEstadoUserAdminInteractor : IGetAllEstadoUserAdminInputPort
{
    private readonly IGetAllEstadoUserAdminOutputPort _outputPort;
    private readonly IReadRepository<EstadoUserAdmin, int> _readRepository;
    
    public GetAllEstadoUserAdminInteractor(
        IGetAllEstadoUserAdminOutputPort outputPort, 
        IReadRepository<EstadoUserAdmin, int> readRepository)
    {
        _outputPort = outputPort;
        _readRepository = readRepository;
    }
    
    
    public async ValueTask Handle()
    {
        var spec = new EstadoUserAdminActivosSpecification();

        var estadosUserAdmins = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<GetAllEstadoUserAdminViewModel> data = estadosUserAdmins
            .Select(p => 
                new GetAllEstadoUserAdminViewModel()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    Color = p.Color,
                    Descripcion = p.Descripcion,

                })
            .ToList()
            .AsReadOnly();

        await _outputPort.Handle(data);
    }
}