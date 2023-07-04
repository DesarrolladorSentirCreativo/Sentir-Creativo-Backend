namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.UsuarioAdmins.Login
{
    public class LoginUsuarioAdminInteractor : ILoginUsuarioAdminInputPort
    {
        private readonly IReadRepository<UsuarioAdmin, int> _readRepository;
        private readonly IReadRepository<UsuarioPrivilegio, int> _usuarioPrivilegioRepository;
        private readonly IReadRepository<PrivilegioAcceso, int> _privilegioAccesoRepository;
        private readonly IReadRepository<UsuarioSucursal, int> _usuarioSucursalRepository;
        private readonly IReadRepository<UsuarioRol, int> _usuarioRolRepository;
        private readonly IReadRepository<RolPrivilegio, int> _rolPrivilegioReoository;
        private readonly ILoginUsuarioAdminOutputPort _outputPort;
        private readonly IEnumerable<IValidator<LoginUsuarioAdminDto>> _validators;
        private readonly IHashPassword _hashPassword;
        private readonly IUserAdminTokenService _userAdminTokenService;

        public LoginUsuarioAdminInteractor(
            IReadRepository<UsuarioAdmin, int> readRepository,
            IReadRepository<UsuarioPrivilegio, int> usuarioPrivilegioRepository,
            IReadRepository<PrivilegioAcceso, int> privilegioAccesoRepository,
            IReadRepository<UsuarioSucursal, int> usuarioSucursalRepository,
            IReadRepository<UsuarioRol, int> usuarioRolRepository,
            IReadRepository<RolPrivilegio, int> rolPrivilegioRepository,
            ILoginUsuarioAdminOutputPort outputPort,
            IEnumerable<IValidator<LoginUsuarioAdminDto>> validators, 
            IHashPassword hashPassword, 
            IUserAdminTokenService userAdminTokenService)
        {
            _readRepository = readRepository;
            _outputPort = outputPort;
            _validators = validators;
            _hashPassword = hashPassword;
            _userAdminTokenService = userAdminTokenService;
            _usuarioPrivilegioRepository = usuarioPrivilegioRepository;
            _privilegioAccesoRepository = privilegioAccesoRepository;
            _usuarioSucursalRepository = usuarioSucursalRepository;
            _usuarioRolRepository = usuarioRolRepository;
            _rolPrivilegioReoository = rolPrivilegioRepository;

        }

        public async ValueTask Handle(LoginUsuarioAdminDto dto)
        {
            //validamos los datos
            await Validator<LoginUsuarioAdminDto>.Validate(dto, _validators);

            var spec = new UsuarioAdminFindByIdEmailSpecification(dto.Email);
            
            var users = await _readRepository.GetAllWithSpec(spec);

            if (users.Count <= 0) throw new Exception("Las credenciales no son validas");

            var user = users[0];
            
           
            if (!_userAdminTokenService.ComparePassword(dto.Password, user.Password!)) throw new Exception("Las credenciales no validas");

            //obtenemos los roles
            List<string> listaIds = new List<string>();
            List<int> listaRolesIds = new List<int>();

            var specRol = new UsuarioRolWithRelationsSpecification(user.Id);

            var roles = await _usuarioRolRepository.GetAllWithSpec(specRol);

            foreach (UsuarioRol rol in roles)
            {
                listaRolesIds.Add(rol.RolId);
            }

            var specRolPrivilegio = new PrivilegioUsuarioRolWithRelationsSpecification(listaRolesIds);
            
            var rolesPrivilegios = await _rolPrivilegioReoository.GetAllWithSpec(specRolPrivilegio);


            foreach (RolPrivilegio rolePrivilegio in rolesPrivilegios)
            {
                listaIds.Add(rolePrivilegio.PrivilegioId);
            }


            //obtenemos los privilegios

            var specUsuarioPrivilegio = new UsuarioPrivilegioWithRelationSpecification(user.Id);
            
            var usuarioPrivilegios = await _usuarioPrivilegioRepository.GetAllWithSpec(specUsuarioPrivilegio);

         

            foreach (UsuarioPrivilegio usuarioPrivilegio in usuarioPrivilegios)
            {
                listaIds.Add(usuarioPrivilegio.PrivilegioId);
            }

            
            
            //ovbtenmos los accesos del privilegio
            var specAccesos = new UsuarioAdminByIdAccesoPrivilegioSpecification(listaIds);

            var accesoPrivilegios = await _privilegioAccesoRepository.GetAllWithSpec(specAccesos);


          IReadOnlyList<UsuarioAdminAccesoViewModel> accesos = accesoPrivilegios
          .Select(p =>
              new UsuarioAdminAccesoViewModel()
              {
                    ColeccionId = p.Acceso.ColeccionId,
                    ModuloId = p.Acceso.Coleccion.ModuloId,
                    Crear = p.Acceso.Crear,
                    Ver = p.Acceso.Ver,
                    Actualizar = p.Acceso.Actualizar,
                    Eliminar = p.Acceso.Eliminar,
                    Listar = p.Acceso.Listar  
              })
          .ToList()
          .AsReadOnly();

            //obtenemos las sucursales
            var specSucursales = new UsuarioSucursalWithRelationsSpecification(user.Id);

            var usuarioSucursales = await _usuarioSucursalRepository.GetAllWithSpec(specSucursales);


           IReadOnlyList<UsuarioAdminSucursalViewModel> sucursales = usuarioSucursales
          .Select(p =>
              new UsuarioAdminSucursalViewModel()
              {
                  SucusalId = p.SucursalId,
                  Nombre = p.Sucursal.Nombre,
              })
          .ToList()
          .AsReadOnly();

            var userToken = new LoginUsuarioAdminViewModel()
            {
                Token = _userAdminTokenService.GenerateTokenAdmin(user),
                Datos = new DatoUsuarioViewModel()
                {
                    UserId = user.Id,
                    Nombre = user.Nombre,
                    Apellidos = user.Apellidos,
                    Alias = user.Alias,
                    Accesos = accesos,
                    Sucursales = sucursales
                   
                },

            };

           await _outputPort.Handle(userToken);
            
        }
    }
}
