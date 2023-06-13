using FluentValidation;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Previsiones;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Previsiones.Create;

public class CreatePrevisionValidator : AbstractValidator<CreatePrevisionDto>
{
     public CreatePrevisionValidator()
     {
          RuleFor(p => p.Nombre)
               .NotEmpty().WithMessage("El nombre es requerido")
               .Length(80).WithMessage("El nombre no debe superar los 80 caracteres");
        
          RuleFor(p => p.Descripcion)
               .Length(1024).WithMessage("La descripción no debe superar los 1024 caracteres");

          RuleFor(p => p.UserId)
               .NotNull().WithMessage("User Id es requerido");
     }
}