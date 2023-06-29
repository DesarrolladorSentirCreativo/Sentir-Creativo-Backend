namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Modulos.GetAll;

public class GetAllModuloInteractor : IGetAllModuloInputPort
{
    private readonly IReadRepository<Modulo,int> _readRepository;
    private readonly IGetAllModuloOutputPort _outputPort;

    public GetAllModuloInteractor(IReadRepository<Modulo, int> readRepository,
        IGetAllModuloOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new ModuloActivosSpecification();

        var modulos = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<GetAllModuloViewModel> data = modulos
            .Select(p => 
                new GetAllModuloViewModel()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    Descripcion = p.Descripcion,

                })
            .ToList()
            .AsReadOnly();

        await _outputPort.Handle(data);
    }
}