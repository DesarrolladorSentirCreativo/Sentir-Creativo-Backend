using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.GetAllWithColecciones;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Modulos.GetAllWithColeccionesModulo;

public class GetAllWithColeccionesModuloInteractor : IGetAllWithColeccionesModuloInputPort
{
    private readonly IReadRepository<Modulo,int> _readModuloRepository;
    private readonly IReadRepository<ColeccionUserAdmin,int> _readColeccionRepository;
    private readonly IGetAllWithColeccionesModuloOutputPort _outputPort;

    public GetAllWithColeccionesModuloInteractor(IReadRepository<Modulo, int> readModuloRepository,
        IReadRepository<ColeccionUserAdmin, int> readColeccionRepository,
        IGetAllWithColeccionesModuloOutputPort outputPort
    )
    {
        _outputPort = outputPort;
        _readColeccionRepository = readColeccionRepository;
        _readModuloRepository = readModuloRepository;
    }
    
    public async ValueTask Handle()
    {
        var spec = new ModuloActivosSpecification();
        
        var modulos = await _readModuloRepository.GetAllWithSpec(spec);

        var specColecciones = new ColeccionByIdsSpecification(modulos);
        
        var colecciones = await _readColeccionRepository.GetAllWithSpec(specColecciones);
        
        IReadOnlyList<GetAllWithColeccionesModuloViewModel> data = modulos
            .Select(p => 
                new GetAllWithColeccionesModuloViewModel()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    Descripcion = p.Descripcion,
                    colecciones = colecciones
                        .Where(x => x.ModuloId == p.Id)
                        .Select(x => new GetAllColeccionUserAdminViewModel()
                    {
                        Id = x.Id,
                        ModuloId = x.ModuloId,
                        Nombre = x.Nombre,
                        Descripcion = x.Descripcion
                    }).ToList()

                })
            .ToList()
            .AsReadOnly();

        await _outputPort.Handle(data);
    }
}