using FluentValidation;
using Microsoft.Extensions.Logging;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Login;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Services;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.FindByEmailAndPassword;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.UserAdmin.Login;

public class LoginUserAdminInteractor : ILoginUserAdminInputPort
{
    private readonly IReadRepository<BusinessObject.POCOEntities.UserAdmin,int> _readRepository;
    private readonly ILoginUserAdminOutputPort _outputPort;
    private readonly IEnumerable<IValidator<LoginUserAdminDto>> _validators;
    private readonly IHashPassword _hashPassword;
    private readonly IUserAdminTokenService _userAdminTokenService;
    private readonly ILogger<LoginUserAdminInteractor> _logger;

    public LoginUserAdminInteractor(
        IReadRepository<BusinessObject.POCOEntities.UserAdmin,int> readRepository,
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
            Token = _userAdminTokenService.GenerateToken(user)
        };

        await _outputPort.Handle(userToken);

        
    }
}