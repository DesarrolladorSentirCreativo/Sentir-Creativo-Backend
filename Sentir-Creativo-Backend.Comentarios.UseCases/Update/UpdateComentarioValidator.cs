using FluentValidation;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.DTO;

namespace Sentir_Creativo_Backend.Comentarios.UseCases.Update;

public class UpdateComentarioValidator : AbstractValidator<UpdateComentarioDto>
{
    public UpdateComentarioValidator()
    {
        RuleFor(p => p.Id)
            .NotNull().WithMessage("El id es requerido");
        
        RuleFor(p => p.Descripcion)
            .NotEmpty().WithMessage("La descripcion es requerido")
            .Length(1000).WithMessage("La descripcion no debe superar los 1000 caracteres");
        
        RuleFor(p => p.UserId)
            .NotNull().WithMessage("el id de usuario es requerido");
    }
}