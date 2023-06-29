namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaPrivilegios.GetById;

public class GetByIdCategoriaPrivilegioInteractor : IGetByIdCategoriaPrivilegioInputPort
{
    private readonly IReadRepository<CategoriaPrivilegio,int> _readRepository;
    private readonly IGetByIdCategoriaPrivilegioOutputPort _outputPort;

    public GetByIdCategoriaPrivilegioInteractor(
        IReadRepository<CategoriaPrivilegio, int> readRepository,
        IGetByIdCategoriaPrivilegioOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle(int categoriaPrivilegioId)
    {
        var spec = new CategoriaPrivilegioActivoByIdSpecification(categoriaPrivilegioId);

        var categoriaPrivilegio = await _readRepository.GetByIdWithSpec(spec);

        if (categoriaPrivilegio == null) throw new NotFoundException("La categoria privilegio no se encuentra registrada");

        var modelView = new GetByIdCategoriaPrivilegioViewModel()
        {
            Id = categoriaPrivilegio.Id,
            Nombre = categoriaPrivilegio.Nombre,
            Descripcion = categoriaPrivilegio.Descripcion
        };
        
        await _outputPort.Handle(modelView);
    }
}