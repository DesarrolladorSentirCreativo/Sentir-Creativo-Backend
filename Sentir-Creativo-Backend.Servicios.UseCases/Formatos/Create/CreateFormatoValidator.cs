﻿namespace Sentir_Creativo_Backend.Servicios.UseCases.Formatos.Create
{
    public class CreateFormatoValidator : AbstractValidator<CreateFormatoDto>
    {
        public CreateFormatoValidator() 
        {
            RuleFor(p => p.Nombre)
          .NotEmpty().WithMessage("El nombre es requerido")
          .NotNull().WithMessage("El nombre es requerido")
          .Length(255).WithMessage("El nombre no debe superar los 255 caracteres");

            RuleFor(p => p.UserId)
            .NotNull().WithMessage("User Id es requerido");
        }
    }
}
