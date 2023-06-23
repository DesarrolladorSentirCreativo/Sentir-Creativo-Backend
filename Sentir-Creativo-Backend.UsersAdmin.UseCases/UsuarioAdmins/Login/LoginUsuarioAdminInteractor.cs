using FluentValidation;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.Login;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Services;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;


namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.UsuarioAdmins.Login
{
    public class LoginUsuarioAdminInteractor : ILoginUsuarioAdminInputPort
    {
        private readonly IReadRepository<UsuarioAdmin, int> _readRepository;
        private readonly ILoginUsuarioAdminOutputPort _outputPort;
        private readonly IEnumerable<IValidator<LoginUsuarioAdminDto>> _validators;
        private readonly IHashPassword _hashPassword;
        private readonly IUserAdminTokenService _userAdminTokenService;

        public LoginUsuarioAdminInteractor(
            IReadRepository<UsuarioAdmin, int> readRepository,
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

            var userToken = new LoginUsuarioAdminViewModel()
            {
                Token = _userAdminTokenService.GenerateTokenAdmin(user),
                Datos = new DatoUsuarioViewModel()
                {
                    Nombre = user.Nombre,
                    Apellidos = user.Apellidos,
                    Alias = user.Alias
                }

            };

           await _outputPort.Handle(userToken);
            
        }
    }
}
