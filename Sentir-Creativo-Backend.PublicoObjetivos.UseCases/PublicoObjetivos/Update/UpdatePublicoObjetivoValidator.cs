namespace Sentir_Creativo_Backend.PublicoObjetivos.UseCases.PublicoObjetivos.Update
{
    public class UpdatePublicoObjetivoValidator : AbstractValidator<UpdatePublicoObjetivoDto>
    {
        public UpdatePublicoObjetivoValidator()
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
