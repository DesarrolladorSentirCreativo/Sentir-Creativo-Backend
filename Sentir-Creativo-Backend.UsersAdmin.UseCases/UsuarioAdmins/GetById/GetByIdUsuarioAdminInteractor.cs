using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Roles;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Sucursales;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.UsuarioAdmins.GetById;

public class GetByIdUsuarioAdminInteractor : IGetByIdUsuarioAdminInputPort
{
    private readonly IReadRepository<UsuarioAdmin,int> _usuarioAdminReadRepository;
    private readonly IReadRepository<CuentaBancaria,int> _cuentaBancariaReadRepository;
    private readonly IReadRepository<UsuarioRol,int> _rolUsuarioReadRepository;
    private readonly IReadRepository<UsuarioAcuerdo, int> _acuerdoUsuarioReadRepository;
    private readonly IReadRepository<UsuarioPrivilegio,int> _privilegioUsuarioReadRepository;
    private readonly IReadRepository<UsuarioSucursal,int> _sucursalUsuarioReadRepository;
    private readonly IGetByIdUsuarioAdminOutputPort _outputPort;
    
    public GetByIdUsuarioAdminInteractor(
        IReadRepository<UsuarioAdmin,int> usuarioAdminReadRepository,
        IReadRepository<CuentaBancaria,int> cuentaBancariaReadRepository,
        IReadRepository<UsuarioRol,int> rolUsuarioReadRepository,
        IReadRepository<UsuarioAcuerdo, int> acuerdoUsuarioReadRepository,
        IReadRepository<UsuarioPrivilegio,int> privilegioUsuarioReadRepository,
        IReadRepository<UsuarioSucursal,int> sucursalUsuarioReadRepository,
        IGetByIdUsuarioAdminOutputPort outputPort)
    {
        _usuarioAdminReadRepository = usuarioAdminReadRepository;
        _cuentaBancariaReadRepository = cuentaBancariaReadRepository;
        _outputPort = outputPort;
        _rolUsuarioReadRepository = rolUsuarioReadRepository;
        _acuerdoUsuarioReadRepository = acuerdoUsuarioReadRepository;
        _privilegioUsuarioReadRepository = privilegioUsuarioReadRepository;
        _sucursalUsuarioReadRepository = sucursalUsuarioReadRepository;
    }

    public async ValueTask Handle(int usuarioAdminId)
    {
        var specUsuario = new UsuarioAdminActivoByIdSpecification(usuarioAdminId);

        var usuario = await _usuarioAdminReadRepository.GetByIdWithSpec(specUsuario);
        
        if(usuario == null) throw new Exception("No existe el usuario");
        
        var specCuentaBancaria = new CuentaBancariaActivoByIdSpecification(usuario.CuentaBancariaId);
        
        var cuentaBancaria = await _cuentaBancariaReadRepository.GetByIdWithSpec(specCuentaBancaria);

        //buscamos los roles del usuario
        var specRoles = new UsuarioRolByIdUsuarioSpecification(usuarioAdminId);
        
        var usuariosRoles = await _rolUsuarioReadRepository.GetAllWithSpec(specRoles);
        
        IReadOnlyList<RolIdDto> roles = usuariosRoles
            .Select(p => 
                new RolIdDto() 
                { RolId = p.RolId
                })
            .ToList()
            .AsReadOnly();
        
        //buscamos los acuerdos
        var usuarioAcuerdoSpec = new UsuarioAcuerdoByIdUsuarioSpecification(usuarioAdminId);

        var usuariosAcuerdos = await _acuerdoUsuarioReadRepository.GetAllWithSpec(usuarioAcuerdoSpec);
        
        IReadOnlyList<AcuerdoIdDto> acuerdos = usuariosAcuerdos
            .Select(p => 
                new AcuerdoIdDto() 
                { AcuerdoId = p.AcuerdoId
                })
            .ToList()
            .AsReadOnly();
        
        //buscamos los privilegios
        var usuarioPrivilegioSpec = new UsuarioPrivilegioByIdUsuarioSpecification(usuarioAdminId);
        
        var usuariosPrivilegios = await _privilegioUsuarioReadRepository.GetAllWithSpec(usuarioPrivilegioSpec);
        
        IReadOnlyList<PrivilegioIdDto> privilegios = usuariosPrivilegios
            .Select(p => 
                new PrivilegioIdDto() 
                { PrivilegioId = p.PrivilegioId
                })
            .ToList()
            .AsReadOnly();
        
        //buscamos sucursales
        var usuarioSucursalSpec = new UsuarioSucursalByIdUsuarioSpecification(usuarioAdminId);
        
        var usuariosSucursales = await _sucursalUsuarioReadRepository.GetAllWithSpec(usuarioSucursalSpec);
        
        IReadOnlyList<SucursalIdDto> sucursales = usuariosSucursales
            .Select(p => 
                new SucursalIdDto() 
                { SucursalId = p.SucursalId
                })
            .ToList()
            .AsReadOnly();

        var data = new GetByIdUsuarioAdminViewModel()
        {
            Id = usuario.Id,
            Nombre = usuario.Nombre,
            Apellidos = usuario.Apellidos,
            Email = usuario.Email,
            NumDocumento = usuario.NumDocumento,
            TipoDocumento = usuario.TipoDocumento,
            PrevisionId = usuario.PrevisionId,
            ModoId = usuario.ModoId,
            AfpId = usuario.AfpId,
            CategoriaId = usuario.CategoriaId,
            ValidaDocumento = usuario.ValidaDocumento,
            FechaFin = usuario.FechaFin,
            FechaPago = usuario.FechaPago,
            FechaInicio = usuario.FechaInicio,
            SueldoBruto = usuario.SueldoBruto,
            EstadoId = usuario.EstadoId,
            Direccion = usuario.Direccion,
            ComunaId = usuario.ComunaId,
            RegionId = usuario.RegionId,
            PaisId = usuario.PaisId,
            CuentaBancariaId = usuario.CuentaBancariaId,
            Banco = usuario != null ? cuentaBancaria.Banco : null,
            TipoCuenta = usuario != null ? cuentaBancaria.TipoCuenta : null,
            NumCuenta = usuario != null ? cuentaBancaria.NumCuenta : null,
            Roles = roles,
            Acuerdos = acuerdos,
            Privilegios = privilegios,
            Sucursales = sucursales
        };

        await _outputPort.Handle(data);
    }
}