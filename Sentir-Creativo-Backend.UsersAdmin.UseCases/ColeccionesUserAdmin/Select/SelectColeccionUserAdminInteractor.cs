namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.ColeccionesUserAdmin.Select;

public class SelectColeccionUserAdminInteractor : ISelectColeccionUserAdminInputPort
{
    private readonly IReadRepository<ColeccionUserAdmin,int> _readRepository;
    private readonly ISelectColeccionUserAdminOutputPort _outputPort;

    public SelectColeccionUserAdminInteractor(IReadRepository<ColeccionUserAdmin, int> readRepository,
        ISelectColeccionUserAdminOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new ColeccionUserAdminWithRelationsSpecification();

        var coleccionesUserAdmin = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectColeccionUserAdminViewModel> data = coleccionesUserAdmin
            .Select(p => 
                new SelectColeccionUserAdminViewModel()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,

                })
            .ToList()
            .AsReadOnly(); 

        await _outputPort.Handle(data);
    }
}
