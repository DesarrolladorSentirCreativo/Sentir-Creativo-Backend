namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaUserAdmins.Select;

public class SelectCategoriaUserAdminInteractor : ISelectCategoriaUserAdminInputPort
{
    private readonly IReadRepository<CategoriaUserAdmin,int> _readRepository;
    private readonly ISelectCategoriaUserAdminOutputPort _outputPort;
    
    public SelectCategoriaUserAdminInteractor(IReadRepository<CategoriaUserAdmin, int> readRepository,
        ISelectCategoriaUserAdminOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }

    public async ValueTask Handle()
    {
        var spec = new CategoriaUserAdminActivosSpecification();

        var categorias = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectCategoriaUserAdminViewModel> data = categorias
            .Select(p => 
                new SelectCategoriaUserAdminViewModel()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,

                })
            .ToList()
            .AsReadOnly();

        await _outputPort.Handle(data);
    }
}