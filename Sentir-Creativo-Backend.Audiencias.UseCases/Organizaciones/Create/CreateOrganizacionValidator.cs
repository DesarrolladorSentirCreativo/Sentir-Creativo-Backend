using FluentValidation;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO.Organizaciones;

namespace Sentir_Creativo_Backend.Audiencias.UseCases.Organizaciones.Create;

public class CreateOrganizacionValidator : AbstractValidator<CreateOrganizacionDto>
{
    public CreateOrganizacionValidator()
    {
        RuleFor(p => p.Nombre)
            .NotEmpty().WithMessage("El nombre es requerido")
            .Length(255).WithMessage("El nombre no debe superar los 255 caracteres");
        
        RuleFor( p => p.Email)
            .Length(255).WithMessage("El email no debe superar los 255 caracteres");
        
        RuleFor( p => p.Facebook)
            .Length(255).WithMessage("El facebook no debe superar los 255 caracteres");
        
        RuleFor( p => p.Twitter)
            .Length(255).WithMessage("El twitter no debe superar los 255 caracteres");
        
        RuleFor( p => p.Website)
            .Length(255).WithMessage("El website no debe superar los 255 caracteres");
        
        RuleFor( p => p.Instagram)
            .Length(255).WithMessage("El instagram no debe superar los 255 caracteres");
        
        RuleFor(p => p.PaisId)
            .NotNull().WithMessage("El pais es requerido");
        
        RuleFor(p => p.RegionId)
            .NotNull().WithMessage("La region es requerida");
        
        RuleFor(p => p.CiudadId)
            .NotNull().WithMessage("La ciudad es requerida");
        
        RuleFor( p => p.Calle)
            .Length(255).WithMessage("La calle no debe superar los 255 caracteres");

        RuleFor(p => p.Historial)
            .Length(255).WithMessage("El historial no debe superar los 255 caracteres");

    }
}