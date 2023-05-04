using FluentValidation;
using Senitr_Creativo_Backend.Comentarios.Entities.DTO;

namespace Sentir_Creativo_Backend.Comentarios.UseCases.Create;

public class CreateComentarioValidator : AbstractValidator<CreateComentarioDto>
{
    public CreateComentarioValidator()
    {
        RuleFor(p => p.Descripcion)
            .NotEmpty().WithMessage("La descripcion es requerido")
            .Length(1000).WithMessage("La descripcion no debe superar los 1000 caracteres");
        
        RuleFor(p => p.UserId)
            .NotNull().WithMessage("el id de usuario es requerido");
    }
}