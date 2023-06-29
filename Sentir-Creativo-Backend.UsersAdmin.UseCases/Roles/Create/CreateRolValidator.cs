namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Roles.Create;

public class CreateRolValidator : AbstractValidator<CreateRolDto>
{
    public CreateRolValidator()
    {
        RuleFor(p => p.Nombre)
            .NotEmpty().WithMessage("El nombre es requerido")
            .Length(80).WithMessage("El nombre no debe superar los 80 caracteres");
        
        RuleFor(p => p.Descripcion)
            .Length(1024).WithMessage("La descripción no debe superar los 1024 caracteres");

        RuleFor(p => p.UserId)
            .NotNull().WithMessage("User Id es requerido");
        
        RuleFor(p => p.Privilegios)
            .NotNull().WithMessage("Los privilegios son obligatorios")
            .NotEmpty().WithMessage("Los privilegios son obligatorios"); 
        
        RuleFor(p => p.Acuerdos)
            .NotNull().WithMessage("Los Acuerdos son obligatorios")
            .NotEmpty().WithMessage("Los Acuerdos son obligatorios"); 
    }
}