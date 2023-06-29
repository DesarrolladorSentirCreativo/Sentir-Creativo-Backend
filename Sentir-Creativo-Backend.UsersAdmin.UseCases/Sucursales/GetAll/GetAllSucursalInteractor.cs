namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Sucursales.GetAll;

public class GetAllSucursalInteractor : IGetAllSucursalInputPort
{
    private readonly IReadRepository<Sucursal,int> _readRepository;
    private readonly IGetAllSucursalOutputPort _outputPort;

    public GetAllSucursalInteractor(
        IReadRepository<Sucursal, int> readRepository,
        IGetAllSucursalOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }

    public async ValueTask Handle()
    {
        var spec = new SucursalActivosSpecification();

        var sucursales = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<GetAllSucursalViewModel> data = sucursales
            .Select(p => 
                new GetAllSucursalViewModel()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    Descripcion = p.Descripcion,
                    Direccion = p.Direccion,
                    PaisId = p.PaisId,
                    RegionId = p.RegionId,
                    CiudadId = p.ComunaId,
                    CreatedAt = p.CreatedAt
                    
                })
            .ToList()
            .AsReadOnly();

        await _outputPort.Handle(data);
    }
}