namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.UsuarioAdmins.GetById;

public class GetByIdUsuarioAdminInteractor : IGetByIdUsuarioAdminInputPort
{
    private readonly IReadRepository<UsuarioAdmin,int> _usuarioAdminReadRepository;
    private readonly IReadRepository<CuentaBancaria,int> _cuentaBancariaReadRepository;
    private readonly IReadRepository<UsuarioRol,int> _rolUsuarioReadRepository;
    private readonly IReadRepository<UsuarioAcuerdo, int> _acuerdoUsuarioReadRepository;
    private readonly IReadRepository<UsuarioPrivilegio,int> _privilegioUsuarioReadRepository;
    private readonly IReadRepository<UsuarioSucursal,int> _sucursalUsuarioReadRepository;
    private readonly IReadRepository<UsuarioArchivo, int> _archivoUsuarioReadRepository;
    private readonly IReadRepository<UsuarioComentario, int> _comentarioUsuarioReadRepository;
    private readonly IGetByIdUsuarioAdminOutputPort _outputPort;

    public GetByIdUsuarioAdminInteractor(
        IReadRepository<UsuarioAdmin, int> usuarioAdminReadRepository,
        IReadRepository<CuentaBancaria, int> cuentaBancariaReadRepository,
        IReadRepository<UsuarioRol, int> rolUsuarioReadRepository,
        IReadRepository<UsuarioAcuerdo, int> acuerdoUsuarioReadRepository,
        IReadRepository<UsuarioPrivilegio, int> privilegioUsuarioReadRepository,
        IReadRepository<UsuarioSucursal, int> sucursalUsuarioReadRepository,
        IReadRepository<UsuarioArchivo, int> archivoUsuarioReadRepository,
        IReadRepository<UsuarioComentario,int> comentarioUsuarioReadRepository,
        IGetByIdUsuarioAdminOutputPort outputPort)
    {
        _usuarioAdminReadRepository = usuarioAdminReadRepository;
        _cuentaBancariaReadRepository = cuentaBancariaReadRepository;
        _outputPort = outputPort;
        _rolUsuarioReadRepository = rolUsuarioReadRepository;
        _acuerdoUsuarioReadRepository = acuerdoUsuarioReadRepository;
        _privilegioUsuarioReadRepository = privilegioUsuarioReadRepository;
        _sucursalUsuarioReadRepository = sucursalUsuarioReadRepository;
        _archivoUsuarioReadRepository = archivoUsuarioReadRepository;
        _comentarioUsuarioReadRepository = comentarioUsuarioReadRepository;
    }

    public async ValueTask Handle(int usuarioAdminId)
    {
        var specUsuario = new UsuarioAdminActivoByIdSpecification(usuarioAdminId);

        var usuario = await _usuarioAdminReadRepository.GetByIdWithSpec(specUsuario);
        
        if(usuario == null) throw new NotFoundException("No existe el usuario");
        
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

        //buscamos los archivos
        var usuarioArchivoSpec = new UsuarioArchivoByIdUsuarioSpecification(usuarioAdminId);

        var usuariosArchivos = await _archivoUsuarioReadRepository.GetAllWithSpec(usuarioArchivoSpec);

        IReadOnlyList<ArchivoViewModel> archivos = usuariosArchivos
            .Select(p =>
                new ArchivoViewModel()
                {
                    Id = p.Archivo!.Id,
                    Path = p.Archivo!.Path,
                    Nombre = p.Archivo!.Nombre!,
                    PublishedAt = p.Archivo.PublishedAt,
                    TipoArchivoId = p.Archivo.TipoArchivoId,
                    TipoArchivo = p.Archivo.TipoArchivo?.Nombre,
                    Publico = p.Archivo?.Publico
                })
            .ToList()
            .AsReadOnly();


        //obtenemos los comentarios del usuario
        var usuarioComentarioSpec = new UsuarioComentarioByIdUsuarioSpecification(usuarioAdminId);

        var usuariosComentarios = await _comentarioUsuarioReadRepository.GetAllWithSpec(usuarioComentarioSpec);

        IReadOnlyList<IdComentarioDto> comentarios = usuariosComentarios
            .Select(p =>
                new IdComentarioDto()
                {
                   ComentarioId = p.ComentarioId
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
            PrefijoId = usuario.PrefijoId,
            ModoId = usuario.ModoId,
            AfpId = usuario.AfpId,
            CategoriaId = usuario.CategoriaId,
            ValidaDocumento = usuario.ValidaDocumento,
            FechaFin = usuario.FechaFin,
            FechaPago = usuario.FechaPago,
            FechaInicio = usuario.FechaInicio,
            SueldoBruto = usuario.SueldoBruto,
            EstadoId = usuario.EstadoId,
            Alias = usuario.Alias,
            Direccion = usuario.Direccion,
            CiudadId = usuario.ComunaId,
            RegionId = usuario.RegionId,
            PaisId = usuario.PaisId,
            CuentaBancariaId = usuario.CuentaBancariaId,
            Banco = usuario != null ? cuentaBancaria.Banco : null,
            TipoCuenta = usuario != null ? cuentaBancaria.TipoCuenta : null,
            NumCuenta = usuario != null ? cuentaBancaria.NumCuenta : null,
            Roles = roles,
            Acuerdos = acuerdos,
            Privilegios = privilegios,
            Sucursales = sucursales,
            Archivos = archivos,
            Comentarios = comentarios,
            EmailPersonal = usuario.EmailPersonal,
            Telefono = usuario.Telefono
        };

        await _outputPort.Handle(data);
    }
}