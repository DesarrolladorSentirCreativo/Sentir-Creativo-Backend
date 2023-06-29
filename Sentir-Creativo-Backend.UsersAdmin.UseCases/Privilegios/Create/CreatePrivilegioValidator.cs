namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Privilegios.Create;

public class CreatePrivilegioValidator : AbstractValidator<CreatePrivilegioDto>
{
    public CreatePrivilegioValidator()
    {
        RuleFor(p => p.Nombre)
            .NotEmpty().WithMessage("El nombre es requerido")
            .Length(50).WithMessage("El nombre no debe superar los 50 caracteres");
        
        RuleFor(p => p.CategoriaId)
            .NotNull().WithMessage("Categoria Privilegio Id es requerido");
        
        RuleFor(p => p.Descripcion)
            .Length(1024).WithMessage("La descripción no debe superar los 1024 caracteres");

        RuleFor(p => p.UserId)
            .NotNull().WithMessage("User Id es requerido");
        
        
        RuleFor(p => p.Accesos)
            .NotNull().WithMessage("Accesos Id es requerido");
        
        
    }
}