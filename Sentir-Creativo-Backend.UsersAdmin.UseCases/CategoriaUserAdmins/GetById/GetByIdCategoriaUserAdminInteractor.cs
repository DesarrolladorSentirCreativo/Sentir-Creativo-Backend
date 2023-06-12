using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaUserAdmins.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.CategoriaUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.CategoriaUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

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

        if (categoria == null) throw new Exception("La categoria no se encuentra registrada");

        var data = new GetByIdCategoriaUserAdminViewModel()
        {
            Id = categoria.Id,
            Nombre = categoria.Nombre,
            Descripcion = categoria.Descripcion,

        };

        await _outputPort.Handle(data);
    }
}