using FluentValidation;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO.Audiencias;

namespace Sentir_Creativo_Backend.Audiencias.UseCases.Audiencias.Create;

public class CreateAudienciaValidator : AbstractValidator<CreateAudienciaDto>
{
    public CreateAudienciaValidator()
    {
        RuleFor(p => p.Nombre)
            .NotEmpty().WithMessage("El nombre es requerido")
            .Length(200).WithMessage("El nobre no debe superar los 200 caracteres");
        
        RuleFor( p => p.Email)
            .NotEmpty().WithMessage("El email es requerido")
            .Length(255).WithMessage("El email no debe superar los 255 caracteres");
        
        RuleFor(p => p.Celular)
            .Length(30).WithMessage("El celular no debe superar los 30 caracteres");
        
        RuleFor(p => p.OrganizacionId)
            .NotNull().WithMessage("OrganizacionId es requerido");
        
        RuleFor(p => p.Departamento)
            .Length(255).WithMessage("El departamento no debe superar los 255 caracteres");
        
        RuleFor(p => p.Cargo)
            .Length(255).WithMessage("El cargo no debe superar los 255 caracteres");
        
        RuleFor(p => p.AntiguedadId)
            .NotNull().WithMessage("La AntiguedadId es requerido");
        
        RuleFor(p => p.CercaniaId)
            .NotNull().WithMessage("La CercaniaId es requerido");
        
        RuleFor(p => p.MotivacionId)
            .NotNull().WithMessage("La MotivacionId es requerido");
        
        RuleFor(p => p.UserId)
            .NotNull().WithMessage("El USerId es requerido");
        
        RuleFor(p => p.Apellido)
            .Length(200).WithMessage("El apellido no debe superar los 200 caracteres");
        
        RuleFor(p => p.EstadoAudienciaId)
            .NotNull().WithMessage("El EstadoAudienciaId es requerido");
        
        RuleFor(p => p.PrefijoId)
            .NotNull().WithMessage("El PrefijoId es requerido");
        
        RuleFor(p => p.OrigenId)
            .NotNull().WithMessage("El OrigenId es requerido");
        
        RuleFor(p => p.Email2)
            .Length(255).WithMessage("El Email2 no debe superar los 255 caracteres");
        
        RuleFor(p => p.DocumentoIdentidad)
            .Length(50).WithMessage("El DocumentoIdentidad no debe superar los 50 caracteres");
        
        RuleFor(p => p.Activo)
            .NotNull().WithMessage("El Activo es requerido");

        RuleFor(p => p.Destacado)
            .NotNull().WithMessage("El destacado es requerido");
    }
}