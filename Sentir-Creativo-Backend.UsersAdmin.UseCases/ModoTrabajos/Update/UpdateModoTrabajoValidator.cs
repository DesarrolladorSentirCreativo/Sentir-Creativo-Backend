namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.ModoTrabajos.Update;

public class UpdateModoTrabajoValidator : AbstractValidator<UpdateModoTrabajoDto>
{
    public UpdateModoTrabajoValidator()
    {
        RuleFor(p => p.Id)
            .NotNull().WithMessage("El id es requerido");
        RuleFor(p => p.Nombre)
            .NotEmpty().WithMessage("El nombre es requerido")
            .Length(80).WithMessage("El nombre no debe superar los 80 caracteres");
        
        RuleFor(p => p.Descripcion)
            .Length(1024).WithMessage("La descripción no debe superar los 1024 caracteres");

        RuleFor(p => p.UserId)
            .NotNull().WithMessage("User Id es requerido");
    }
}