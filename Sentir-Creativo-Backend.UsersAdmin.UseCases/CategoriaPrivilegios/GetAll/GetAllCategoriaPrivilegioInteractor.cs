using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaPrivilegios.GetAll;

public class GetAllCategoriaPrivilegioInteractor : IGetAllCategoriaPrivilegioInputPort
{
    private readonly IReadRepository<CategoriaPrivilegio,int> _readRepository;
    private readonly IGetAllCategoriaPrivilegioOutputPort _outputPort;

    public GetAllCategoriaPrivilegioInteractor(
        IReadRepository<CategoriaPrivilegio,int> readRepository,
        IGetAllCategoriaPrivilegioOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new CategoriaPrivilegioActivosSpecification();

        var categoriasPrivilegios = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<GetAllCategoriaPrivilegioViewModel> data = categoriasPrivilegios
            .Select(p => 
                new GetAllCategoriaPrivilegioViewModel()
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