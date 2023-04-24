using FluentValidation;
using Sentir_Creativo_Backend.Archivos.BusinessObject.DTO;

namespace sentir_Creativo_Backend.Archivos.UseCases.Archivos.Create;

public class CreateArchivoValidator : AbstractValidator<CreateArchivoDto>
{
    public CreateArchivoValidator()
    {
        RuleFor(p => p.Nombre)
            .NotEmpty().WithMessage("El nombre es requerido")
            .Length(255).WithMessage("El nombre no debe superar los 255 caracteres");
        
        RuleFor(p => p.Path)
            .NotEmpty().WithMessage("El path es requerido")
            .Length(255).WithMessage("El path no debe superar los 255 caracteres");

        RuleFor(p => p.TipoArchivoId)
            .NotNull().WithMessage("Tipo de archivo es requerido");
        
        RuleFor(p => p.Publico)
            .NotNull().WithMessage("Publico es requerido");
    }
}