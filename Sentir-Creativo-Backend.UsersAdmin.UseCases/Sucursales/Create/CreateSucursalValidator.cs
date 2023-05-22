using FluentValidation;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Sucursales;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Sucursales.Create;

public class CreateSucursalValidator : AbstractValidator<CreateSucursalDto>
{
    public CreateSucursalValidator()
    {
        RuleFor(p => p.Nombre)
            .NotEmpty().WithMessage("El nombre es requerido")
            .Length(60).WithMessage("El nombre no debe superar los 60 caracteres");
        
        RuleFor(p => p.Descripcion)
            .Length(1024).WithMessage("La descripción no debe superar los 1024 caracteres");
        
        RuleFor(p => p.Direccion)
            .NotEmpty().WithMessage("La dirección es requerida")
            .Length(1024).WithMessage("La dirección no debe superar los 1024 caracteres");
        
        RuleFor(p => p.PaisId)
            .NotNull().WithMessage("País Id es requerido");
        
        RuleFor(p => p.RegionId)
           .NotNull().WithMessage("Region Id es requerido");
        
        RuleFor(p => p.ComunaId)
            .NotNull().WithMessage("Comuna Id es requerido");
        
        RuleFor(p => p.UserId)
            .NotNull().WithMessage("User Id es requerido");
        
    }
}