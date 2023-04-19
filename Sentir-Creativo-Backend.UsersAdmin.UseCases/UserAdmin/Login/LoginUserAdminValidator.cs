using FluentValidation;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.UserAdmin.Login;

public class LoginUserAdminValidator : AbstractValidator<LoginUserAdminDto>
{
    public LoginUserAdminValidator()
    {
        RuleFor(p => p.Email)
            .NotEmpty().WithMessage("El email es requerido")
            .EmailAddress().WithMessage("El email no es valido")
            .Length(255).WithMessage("El email no debe superar los 255 caracteres");
        
        RuleFor(p => p.Password)
            .NotEmpty().WithMessage("El password es requerido")
            .Length(255).WithMessage("El password no es valido");
    }
}