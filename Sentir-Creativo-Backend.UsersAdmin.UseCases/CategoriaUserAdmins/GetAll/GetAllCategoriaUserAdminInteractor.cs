using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaUserAdmins.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.CategoriaUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.CategoriaUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaUserAdmins.GetAll;

public class GetAllCategoriaUserAdminInteractor : IGetAllCategoriaUserAdminInputPort
{
 
    private readonly IReadRepository<CategoriaUserAdmin,int> _readRepository;
    private readonly IGetAllCategoriaUserAdminOutputPort _outputPort;
    
    public GetAllCategoriaUserAdminInteractor(IReadRepository<CategoriaUserAdmin, int> readRepository,
        IGetAllCategoriaUserAdminOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new CategoriaUserAdminActivosSpecification();

        var categorias = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<GetAllCategoriaUserAdminViewModel> data = categorias
            .Select(p => 
                new GetAllCategoriaUserAdminViewModel()
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