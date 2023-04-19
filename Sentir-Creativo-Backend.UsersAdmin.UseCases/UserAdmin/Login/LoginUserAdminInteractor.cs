using FluentValidation;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Login;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.FindByEmailAndPassword;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.UserAdmin.Login;

public class LoginUserAdminInteractor : ILoginUserAdminInputPort
{
    private readonly IReadRepository<BusinessObject.POCOEntities.UserAdmin,int> _readRepository;
    private readonly ILoginUserAdminOutputPort _outputPort;
    private readonly IEnumerable<IValidator<LoginUserAdminDto>> _validators;
    private readonly IHashPassword _hashPassword;

    public LoginUserAdminInteractor(
        IReadRepository<BusinessObject.POCOEntities.UserAdmin,int> readRepository,
        ILoginUserAdminOutputPort outputPort,
        IEnumerable<IValidator<LoginUserAdminDto>> validators,
        IHashPassword hashPassword)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
        _validators = validators;
        _hashPassword = hashPassword;
    }

    public async ValueTask Handle(LoginUserAdminDto dto)
    {
        //validamos los datos
        await Validator<LoginUserAdminDto>.Validate(dto, _validators);

        var spec = new UserAdminFindByEmailSpecification(dto.Email);

        var user = await _readRepository.GetByIdWithSpec(spec);

        if (user == null) throw new Exception("Las credenciales no son validas");

        string passwordLogin = _hashPassword.Handle(dto.Password);
        
        if(user.Password != passwordLogin) throw new Exception("Las credenciales no son validas");
        
        
    }
}