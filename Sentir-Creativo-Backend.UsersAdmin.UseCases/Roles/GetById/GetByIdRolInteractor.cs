using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Roles;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Roles;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Roles.GetById;

public class GetByIdRolInteractor : IGetByIdRolInputPort
{
    private readonly IReadRepository<Rol,int> _readRepository;
    private readonly IGetByIdRolOutputPort _outputPort;
    private readonly IReadRepository<RolAcuerdo,int> _readRolAcuerdoRepository;
    private readonly IReadRepository<RolPrivilegio, int> _readRepositoryRolPrivilegioRepository;

    public GetByIdRolInteractor(
        IReadRepository<Rol, int> readRepository,
        IGetByIdRolOutputPort outputPort,
        IReadRepository<RolAcuerdo,int> readRolAcuerdoRepository,
        IReadRepository<RolPrivilegio,int> readRepositoryRolPrivilegioRepository)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
        _readRolAcuerdoRepository = readRolAcuerdoRepository;
        _readRepositoryRolPrivilegioRepository = readRepositoryRolPrivilegioRepository;
    }
    
    public async ValueTask Handle(int rolId)
    {
        var spec = new RolActivoByIdSpecification(rolId);

        var rol = await _readRepository.GetByIdWithSpec(spec);

        if (rol == null) throw new Exception("El rol no se encuentra registrada");

        //obtenemos los acuerdos del rol
        var specAcuerdos = new RolAcuerdoByIdRolSpecification(rolId);

        var rolAcuerdos = await _readRolAcuerdoRepository.GetAllWithSpec(specAcuerdos);
        
        //obtenemos los privilegios del rol
        var specPrivilegios = new RolPrivilegioByIdRolSpecification(rolId);

        var rolPrivilegios = await _readRepositoryRolPrivilegioRepository.GetAllWithSpec(specPrivilegios);

        var data = new GetByIdRolViewModel()
        {
            Id = rol.Id,
            Nombre = rol.Nombre,
            Descripcion = rol.Descripcion,
            Acuerdos = rolAcuerdos.Select(x => new AcuerdoIdDto()
            {
                AcuerdoId = x.AcuerdoId
            }).ToList(),
            Privilegios = rolPrivilegios.Select(x => new PrivilegioIdDto()
            {
                PrivilegioId = x.PrivilegioId
            }).ToList()
        };
        
        await _outputPort.Handle(data);
    }
}