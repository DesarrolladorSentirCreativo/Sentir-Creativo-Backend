namespace Sentir_Creativo_Backend.Servicios.UseCases.EstadoServicios.Create
{
    public class CreateEstadoServicioValidator : AbstractValidator<CreateEstadoServicioDto>
    {
        public CreateEstadoServicioValidator() 
        {
            RuleFor(p => p.Nombre)
            .NotEmpty().WithMessage("El nombre es requerido")
            .Length(255).WithMessage("El nombre no debe superar los 255 caracteres");

            RuleFor(p => p.Color)
                .NotEmpty().WithMessage("El color es requerido")
                .Length(8).WithMessage("El color no debe superar los 8 caracteres");

            RuleFor(p => p.Descripcion)
                .Length(1024).WithMessage("La descripción no debe superar los 1024 caracteres");

            RuleFor(p => p.UserId)
                .NotNull().WithMessage("User Id es requerido");
        }

    }
}
