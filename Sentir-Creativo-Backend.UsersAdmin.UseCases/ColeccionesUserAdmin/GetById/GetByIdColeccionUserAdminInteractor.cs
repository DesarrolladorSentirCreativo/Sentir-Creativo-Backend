namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.ColeccionesUserAdmin.GetById;

public class GetByIdColeccionUserAdminInteractor : IGetByIdColeccionUserAdminInputPort
{
    private readonly IReadRepository<ColeccionUserAdmin,int> _readRepository;
    private readonly IGetByIdColeccionUserAdminOutputPort _outputPort;

    public GetByIdColeccionUserAdminInteractor(
        IReadRepository<ColeccionUserAdmin, int> readRepository,
        IGetByIdColeccionUserAdminOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle(int coleccionUserAdminId)
    {
        var spec = new ColeccionUserAdminActivoByIdSpecification(coleccionUserAdminId);

        var coleccionUserAdmin = await _readRepository.GetByIdWithSpec(spec);

        if (coleccionUserAdmin == null) throw new NotFoundException("La coleccion no se encuentra registrada");

        var data = new GetByIdColeccionUserAdminViewModel()
        {
            Id = coleccionUserAdmin.Id,
            Nombre = coleccionUserAdmin.Nombre,
            ModuloId = coleccionUserAdmin.ModuloId,
            Descripcion = coleccionUserAdmin.Descripcion

        };
            
        await _outputPort.Handle(data);
    }
}