namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.ColeccionesUserAdmin.GetAll;

public class GetAllColeccionUserAdminInteractor : IGetAllColeccionUserAdminInputPort
{
    private readonly IReadRepository<ColeccionUserAdmin,int> _readRepository;
    private readonly IGetAllColeccionUserAdminOutputPort _outputPort;

    public GetAllColeccionUserAdminInteractor(IReadRepository<ColeccionUserAdmin, int> readRepository,
        IGetAllColeccionUserAdminOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new ColeccionUserAdminWithRelationsSpecification();

        var coleccionesUserAdmin = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<GetAllColeccionUserAdminViewModel> data = coleccionesUserAdmin
            .Select(p => 
                new GetAllColeccionUserAdminViewModel()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    ModuloId = p.ModuloId,
                    Descripcion = p.Descripcion,

                })
            .ToList()
            .AsReadOnly(); 

        await _outputPort.Handle(data);
    }
}