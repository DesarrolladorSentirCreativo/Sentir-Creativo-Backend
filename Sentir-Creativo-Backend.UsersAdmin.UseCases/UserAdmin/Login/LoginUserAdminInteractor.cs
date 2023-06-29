

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.UserAdmin.Login;

public class LoginUserAdminInteractor : ILoginUserAdminInputPort
{
    private readonly IReadRepository<Entities.POCOEntities.UserAdmin,int> _readRepository;
    private readonly ILoginUserAdminOutputPort _outputPort;
    private readonly IEnumerable<IValidator<LoginUserAdminDto>> _validators;
    private readonly IHashPassword _hashPassword;
    private readonly IUserAdminTokenService _userAdminTokenService;
    private readonly ILogger<LoginUserAdminInteractor> _logger;

    public LoginUserAdminInteractor(
        IReadRepository<Entities.POCOEntities.UserAdmin,int> readRepository,
        ILoginUserAdminOutputPort outputPort,
        IEnumerable<IValidator<LoginUserAdminDto>> validators,
        IHashPassword hashPassword,
        IUserAdminTokenService userAdminTokenService,
        ILogger<LoginUserAdminInteractor> logger)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
        _validators = validators;
        _hashPassword = hashPassword;
        _userAdminTokenService = userAdminTokenService;
        _logger = logger;
    }

    public async ValueTask Handle(LoginUserAdminDto dto)
    {
        //validamos los datos
        await Validator<LoginUserAdminDto>.Validate(dto, _validators);

        var spec = new UserAdminFindByEmailSpecification(dto.Email);

        var users = await _readRepository.GetAllWithSpec(spec);
        
        if (users.Count <= 0) throw new Exception("Las credenciales no son validas");

        var user = users[0];
        
        if(!_userAdminTokenService.ComparePassword(dto.Password,user.Password!)) throw new Exception("Las credenciales no son iguais");

        var userToken = new UserAdminTokenViewModel()
        {
            Token = _userAdminTokenService.GenerateToken(user),
            User = new UserViewModel(){
                UserId = user.Id,
                Email = user.Email,
                UserName = user.UserName
            }
        };

        await _outputPort.Handle(userToken);
    }
}