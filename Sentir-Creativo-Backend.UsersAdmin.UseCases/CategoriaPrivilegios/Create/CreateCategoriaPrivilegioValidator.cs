namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaPrivilegios.Create;

public class CreateCategoriaPrivilegioValidator : AbstractValidator<CreateCategoriaPrivilegioDto>
{
    public CreateCategoriaPrivilegioValidator()
    {
        RuleFor(p => p.Nombre)
            .NotEmpty().WithMessage("El nombre es requerido")
            .Length(50).WithMessage("El nombre no debe superar los 50 caracteres");
        
        RuleFor(p => p.Descripcion)
            .Length(1024).WithMessage("La descripción no debe superar los 256 caracteres");
        
        RuleFor(p => p.UserId)
            .NotNull().WithMessage("User Id es requerido");
    }
}