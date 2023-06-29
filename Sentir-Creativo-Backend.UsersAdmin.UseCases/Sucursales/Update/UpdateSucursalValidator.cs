namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Sucursales.Update;

public class UpdateSucursalValidator : AbstractValidator<UpdateSucursalDto>
{
    public UpdateSucursalValidator()
    {
        RuleFor(p => p.Id)
            .NotNull().WithMessage("El id es requerido");
        
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
        
        RuleFor(p => p.CiudadId)
            .NotNull().WithMessage("Comuna Id es requerido");
        
        RuleFor(p => p.UserId)
            .NotNull().WithMessage("User Id es requerido");

    }
}