using FluentValidation;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.UsuarioAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.UsuarioAdmins.Login
{
    public class LoginUsuarioAdminValidator : AbstractValidator<LoginUsuarioAdminDto>
    {
        public LoginUsuarioAdminValidator()
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
}
