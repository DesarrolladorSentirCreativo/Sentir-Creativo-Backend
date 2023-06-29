namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.EstadoUserAdmins.Create;

public class CreateEstadoUserAdminValidator : AbstractValidator<CreateEstadoUserAdminDto>
{
    public CreateEstadoUserAdminValidator()
    {
        RuleFor(p => p.Nombre)
            .NotEmpty().WithMessage("El nombre es requerido")
            .Length(80).WithMessage("El nombre no debe superar los 80 caracteres");
        
        RuleFor(p => p.Color)
            .NotEmpty().WithMessage("El color es requerido")
            .Length(8).WithMessage("El color no debe superar los 8 caracteres");
        
        RuleFor(p => p.Descripcion)
            .Length(1024).WithMessage("La descripción no debe superar los 1024 caracteres");

        RuleFor(p => p.UserId)
            .NotNull().WithMessage("User Id es requerido");
    }
}