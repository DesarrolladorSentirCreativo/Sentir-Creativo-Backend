using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.Entities.Exceptions;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Modulos.GetById;

public class GetByIdModuloInteractor : IGetByIdModuloInputPort
{
    private readonly IReadRepository<Modulo,int> _readRepository;
    private readonly IGetByIdModuloOutputPort _outputPort;

    public GetByIdModuloInteractor(IReadRepository<Modulo, int> readRepository, IGetByIdModuloOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle(int moduloId)
    {
        var spec = new ModuloActivoByIdSpecification(moduloId);

        var modulo = await _readRepository.GetByIdWithSpec(spec);
        
        if (modulo == null) throw new NotFoundException("El modulo no se encuentra registrado");

        var data = new GetByIdModuloViewModel()
        {
            Id = modulo.Id,
            Nombre = modulo.Nombre,
            Descripcion = modulo.Descripcion,
        };

        await _outputPort.Handle(data);

    }
}