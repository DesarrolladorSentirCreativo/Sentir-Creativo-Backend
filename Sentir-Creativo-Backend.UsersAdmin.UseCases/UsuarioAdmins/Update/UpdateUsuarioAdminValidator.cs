using FluentValidation;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.UsuarioAdmins;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.UsuarioAdmins.Update;

public class UpdateUsuarioAdminValidator : AbstractValidator<UpdateUsuarioAdminDto>
{
    public UpdateUsuarioAdminValidator()
    {
         RuleFor(p => p.Nombre)
            .NotEmpty().WithMessage("El nombre es requerido")
            .Length(80).WithMessage("El nombre no debe superar los 80 caracteres");
        
        RuleFor(p => p.Apellidos)
            .NotEmpty().WithMessage("Los apellidos es requerido")
            .Length(80).WithMessage("Los apellidos no debe superar los 80 caracteres");
        
        RuleFor(p => p.PrevisionId)
            .NotNull().WithMessage("Prevision Id es requerido");
        
        RuleFor(p => p.AfpId)
            .NotNull().WithMessage("Afp Id es requerido");
        
        RuleFor(p => p.ModoId)
            .NotNull().WithMessage("Modo Id es requerido");
        
        RuleFor(p => p.CategoriaId)
            .NotNull().WithMessage("Categoria Id es requerido");
        
        RuleFor(p => p.ValidaDocumento)
            .NotNull().WithMessage("Valida Documento es requerido");
        
        RuleFor(p => p.TipoDocumento)
            .NotEmpty().WithMessage("El tipo de documento es requerido")
            .Length(20).WithMessage("El tipo de documento no debe superar los 20 caracteres");
        
        RuleFor(p => p.NumDocumento)
            .NotEmpty().WithMessage("El numero de documento es requerido")
            .Length(30).WithMessage("El numero de documento no debe superar los 30 caracteres");
        
        RuleFor(p => p.FechaPago)
            .NotNull().WithMessage("Fecha de pago es requerido");
        
        RuleFor(p => p.SueldoBruto)
            .NotNull().WithMessage("Sueldo Bruto es requerido");
        
        RuleFor(p => p.FechaInicio)
            .NotNull().WithMessage("Fecha de inicio es requerido");
        
        RuleFor(p => p.EstadoId)
            .NotNull().WithMessage("Estado Id es requerido");
        
        RuleFor(p => p.Password)
            .NotEmpty().WithMessage("El password es requerido")
            .Length(40).WithMessage("El password no debe superar los 40 caracteres");
        
        RuleFor(p => p.Email)
            .NotEmpty().WithMessage("El email es requerido")
            .Length(256).WithMessage("El email no debe superar los 256 caracteres")
            .EmailAddress().WithMessage("El email no es valido");

        RuleFor(p => p.Direccion)
            .Length(1024).WithMessage("La direccion no debe superar los 1024 caracteres");
        
        RuleFor(p => p.CiudadId)
            .NotNull().WithMessage("Comuna Id es requerido");

        RuleFor(p => p.RegionId)
            .NotNull().WithMessage("Region Id es requerido");
        
        RuleFor(p => p.PaisId)
            .NotNull().WithMessage("Pais Id es requerido");
        
        RuleFor(p => p.UserId)
            .NotNull().WithMessage("User Id es requerido");
        
        RuleFor(p => p.Sucursales)
            .NotNull().WithMessage("Sucursales Id es requerido");
        
        RuleFor(p => p.Roles)
            .NotNull().WithMessage("Roles Id es requerido");
    }
}