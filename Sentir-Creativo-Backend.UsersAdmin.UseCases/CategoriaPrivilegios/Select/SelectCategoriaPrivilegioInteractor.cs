namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaPrivilegios.Select;

public class SelectCategoriaPrivilegioInteractor : ISelectCategoriaPrivilegioInputPort
{
    private readonly IReadRepository<CategoriaPrivilegio,int> _readRepository;
    private readonly ISelectCategoriaPrivilegioOutputPort _outputPort;
    
    public SelectCategoriaPrivilegioInteractor(
        IReadRepository<CategoriaPrivilegio,int> readRepository,
        ISelectCategoriaPrivilegioOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new CategoriaPrivilegioActivosSpecification();

        var categoriasPrivilegios = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectCategoriaPrivilegioViewModel> data = categoriasPrivilegios
            .Select(p => 
                new SelectCategoriaPrivilegioViewModel()
                {
                    Id = p.Id,
                    Nombre = p.Nombre

                })
            .ToList()
            .AsReadOnly();

        await _outputPort.Handle(data);
    }
}