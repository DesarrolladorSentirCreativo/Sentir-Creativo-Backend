namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.EstadoUserAdmins.GetById;

public class GetByIdEstadoUserAdminInteractor : IGetByIdEstadoUserAdminInputPort
{
    private readonly IGetByIdEstadoUserAdminOutputPort _outputPort;
    private readonly IReadRepository<EstadoUserAdmin, int> _readRepository;
    
    public GetByIdEstadoUserAdminInteractor(
        IGetByIdEstadoUserAdminOutputPort outputPort, 
        IReadRepository<EstadoUserAdmin, int> readRepository)
    {
        _outputPort = outputPort;
        _readRepository = readRepository;
    }
    
    public async ValueTask Handle(int estadoId)
    {
        var spec = new EstadoUserAdminActivoByIdSpecification(estadoId);

        var estadoUserAdmin = await _readRepository.GetByIdWithSpec(spec);

        if (estadoUserAdmin == null) throw new NotFoundException("El estado de useradmin no se encuentra registrado");

        var data = new GetByIdEstadoUserAdminViewModel()
        {
            Id = estadoUserAdmin.Id,
            Nombre = estadoUserAdmin.Nombre,
            Color = estadoUserAdmin.Color,
            Descripcion = estadoUserAdmin.Descripcion,
        };
        
        await _outputPort.Handle(data);
    }
}