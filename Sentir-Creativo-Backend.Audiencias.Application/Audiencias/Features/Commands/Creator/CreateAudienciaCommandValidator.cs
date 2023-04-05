using FluentValidation;

namespace Sentir_Creativo_Backend.Audiencias.Application.Audiencias.Features.Commands.Creator;

public class CreateAudienciaCommandValidator : AbstractValidator<CreateAudienciaCommand>
{
    public CreateAudienciaCommandValidator()
    {
        RuleFor(p => p.Nombre)
            .NotNull().WithMessage("{Nombre} no puede ser nulo")
            .Length(200).WithMessage("{Nombre} no puede superar los 200 caracteres");
        RuleFor(p => p.Apellido)
            .Length(200).WithMessage("{Apellido} no puede superar los 200 caracteres");
        RuleFor(p => p.Email)
            .NotNull().WithMessage("{Email} no puede ser nulo")
            .Length(255).WithMessage("{Email} no puede superar los 255 caracteres");
        RuleFor(p => p.Profesion).Length(255)
            .WithMessage("{Profesion} no puede superar los 255 caracteres");
        RuleFor(p => p.Celular)
            .Length(30).WithMessage("{Celular} no puede superar los 30 caracteres");
        RuleFor(p => p.OrganizacionId)
            .NotNull().WithMessage("{OrganizacionId} no puede ser nulo");
        RuleFor(p => p.CercaniaId)
            .NotNull().WithMessage("{CercaniaId} no puede ser nulo");
        RuleFor(p => p.OrigenId)
            .NotNull().WithMessage("{OrigenId} no puede ser nulo");
        RuleFor(p => p.MotivacionId)
            .NotNull().WithMessage("{MotivacionId} no puede ser nulo");
        RuleFor(p => p.PrefijoId)
            .NotNull().WithMessage("{PrefijoId} no puede ser nulo");
        RuleFor(p => p.AntiguedadId)
            .NotNull().WithMessage("{AntiguedadId} no puede ser nulo");
        RuleFor(p => p.Departamento)
            .Length(255).WithMessage("{Departamemto} no puede superar los 255 caracteres");
        RuleFor(p => p.Cargo)
            .Length(255).WithMessage("{Cargo} no puede superar los 255 caracteres");
        RuleFor(p => p.Email2)
            .Length(255).WithMessage("{Email2} no puede superar los 255 caracteres");
        RuleFor(p => p.EstadoId)
            .NotNull().WithMessage("{EstadoId} no puede ser nulo");
        RuleFor(p => p.DocumentoIdentidad)
            .Length(255).WithMessage("{DocumentoIdentidad} no puede superar los 50 caracteres");

    }
}