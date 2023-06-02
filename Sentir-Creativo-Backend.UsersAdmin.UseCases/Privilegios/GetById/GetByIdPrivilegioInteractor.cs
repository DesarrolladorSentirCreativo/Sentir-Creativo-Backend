using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Privilegios.GetById;

public class GetByIdPrivilegioInteractor : IGetByIdPrivilegioInputPort
{
    private readonly IReadRepository<Privilegio,string> _privilegioReadRepository;
    private readonly IReadRepository<Acceso, string> _accesoReadRepository;
    private readonly IReadRepository<PrivilegioAcceso,int> _privilegioAccesoReadRepository;
    private readonly IGetByIdPrivilegioOutputPort _outputPort;

    public GetByIdPrivilegioInteractor(IReadRepository<Privilegio, string> privilegioReadRepository,
        IReadRepository<Acceso, string> accesoReadRepository,
        IGetByIdPrivilegioOutputPort outputPort,
        IReadRepository<PrivilegioAcceso,int> privilegioAccesoReadRepository)
    {
        _accesoReadRepository = accesoReadRepository;
        _privilegioReadRepository = privilegioReadRepository;
        _outputPort = outputPort;
        _privilegioAccesoReadRepository = privilegioAccesoReadRepository;
    }
    
    public async ValueTask Handle(string privilegiId)
    {
        //buscamos el privilegio
        var spec = new PrivilegioActivoByIdSpecification(privilegiId);

        var privilegio = await _privilegioReadRepository.GetByIdWithSpec(spec);

        if (privilegio == null) throw new Exception("El privilegio no se encuentra registrado");
        
        //buscamos los accesos del privilegio
        var specPrivilegioAcceso = new PrivilegioAccesoByPrivilegioIdSpecification(privilegio.Id);
        
        var privilegioAccesos = await _privilegioAccesoReadRepository.GetAllWithSpec(specPrivilegioAcceso);
        
        IReadOnlyList<AccesoId> accesosId = privilegioAccesos
            .Select(p => 
                new AccesoId()
                {
                    Id = p.AccesoId
                })
            .ToList()
            .AsReadOnly();
        
        //obtenemos todos los accesos
        var specAccesos = new AccesoByIdSpecification(accesosId);

        var accesos = await _accesoReadRepository.GetAllWithSpec(specAccesos);
        
        //juntamos la informacion obtenida
        var data = new GetByIdPrivilegioViewModel()
        {
            Id = privilegio.Id,
            Nombre = privilegio.Nombre,
            CategoriaId = privilegio.CategoriaId,
            Descripcion = privilegio.Descripcion,
            Accesos = accesos.Select(x => new AccesoViewModel()
            {
                Id = x.Id,
                ColeccionId = x.ColeccionId,
                Crear = x.Crear,
                Actualizar = x.Actualizar,
                Listar = x.Listar,
                Eliminar = x.Eliminar,
                Ver = x.Ver
            }).ToList()
        };

        await _outputPort.Handle(data);
    }
}