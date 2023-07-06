﻿
using FluentValidation;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Dtos.Ocacions;

namespace Sentir_Creativo_Backend.Servicios.UseCases.Ocacions.Update
{
    public class UpdateOcacionValidator : AbstractValidator<UpdateOcacionDto>

    { 
        public UpdateOcacionValidator()
        {
            RuleFor(p => p.Id)
           .NotNull().WithMessage("El id es requerido");

            RuleFor(p => p.Nombre)
           .NotEmpty().WithMessage("El nombre es requerido")
           .NotNull().WithMessage("El nombre es requerido")
           .Length(255).WithMessage("El nombre no debe superar los 255 caracteres");

            RuleFor(p => p.UserId)
            .NotNull().WithMessage("User Id es requerido");

        }
    }
}
