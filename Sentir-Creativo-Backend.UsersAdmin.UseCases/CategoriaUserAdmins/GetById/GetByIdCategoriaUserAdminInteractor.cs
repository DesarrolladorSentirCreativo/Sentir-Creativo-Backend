namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaUserAdmins.GetById;

public class GetByIdCategoriaUserAdminInteractor : IGetByIdCategoriaUserAdminInputPort
{
    private readonly IReadRepository<CategoriaUserAdmin,int> _readRepository;
    private readonly IGetByIdCategoriaUserAdminOutputPort _outputPort;
    
    public GetByIdCategoriaUserAdminInteractor(IReadRepository<CategoriaUserAdmin, int> readRepository,
        IGetByIdCategoriaUserAdminOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle(int categoriaId)
    {
        var spec = new CategoriaUserAdminActivoByIdSpecification(categoriaId);

        var categoria = await _readRepository.GetByIdWithSpec(spec);

        if (categoria == null) throw new NotFoundException("La categoria no se encuentra registrada");

        var data = new GetByIdCategoriaUserAdminViewModel()
        {
            Id = categoria.Id,
            Nombre = categoria.Nombre,
            Descripcion = categoria.Descripcion,

        };

        await _outputPort.Handle(data);
    }
}