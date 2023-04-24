using FluentValidation;
using Sentir_Creativo_Backend.Bitacoras.BusinessObjects.DTO;

namespace Sentir_Creativo_Backend.Bitacoras.UseCases.Bitacoras.Create;

public class CreateBitacoraValidator : AbstractValidator<CreateBitacoraDto>
{
    public CreateBitacoraValidator()
    {
        RuleFor(p => p.Entidad)
            .Length(255).WithMessage("La entidad no debe superar los 255 caracteres");
        
        RuleFor(p => p.Accion)
            .Length(255).WithMessage("La accion no debe superar los 255 caracteres");

        RuleFor(p => p.Autor)
            .Length(255).WithMessage("El autor no debe superar los 255 caracteres");
        
        RuleFor(p => p.Via)
            .Length(255).WithMessage("la via no debe superar los 255 caracteres");

        RuleFor(p => p.UserId)
            .NotNull().WithMessage("el usuario es requiredo");
        
        RuleFor(p => p.Fecha)
            .NotNull().WithMessage("La fecha es requerida");
    }
}