using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.UsuarioAdmins.GetById;

public class GetByIdUsuarioAdminInteractor : IGetByIdUsuarioAdminInputPort
{
    private readonly IReadRepository<UsuarioAdmin,int> _usuarioAdminReadRepository;
    private readonly IReadRepository<CuentaBancaria,int> _cuentaBancariaReadRepository;
    private readonly IGetByIdUsuarioAdminOutputPort _outputPort;
    
    public GetByIdUsuarioAdminInteractor(
        IReadRepository<UsuarioAdmin,int> usuarioAdminReadRepository,
        IReadRepository<CuentaBancaria,int> cuentaBancariaReadRepository,
        IGetByIdUsuarioAdminOutputPort outputPort)
    {
        _usuarioAdminReadRepository = usuarioAdminReadRepository;
        _cuentaBancariaReadRepository = cuentaBancariaReadRepository;
        _outputPort = outputPort;
    }

    public async ValueTask Handle(int usuarioAdminId)
    {
        var specUsuario = new UsuarioAdminActivoByIdSpecification(usuarioAdminId);

        var usuario = await _usuarioAdminReadRepository.GetByIdWithSpec(specUsuario);
        
        if(usuario == null) throw new Exception("No existe el usuario");
        
        var specCuentaBancaria = new CuentaBancariaActivoByIdSpecification(usuario.CuentaBancariaId);
        
        var cuentaBancaria = await _cuentaBancariaReadRepository.GetByIdWithSpec(specCuentaBancaria);

        var data = new GetByIdUsuarioAdminViewModel()
        {
            Id = usuario.Id,
            Nombre = usuario.Nombre,
            Apellidos = usuario.Apellidos,
            Email = usuario.Email,
            NumDocumento = usuario.NumDocumento,
            TipoDocumento = usuario.TipoDocumento,
            PrevisionId = usuario.PrevisionId,
            ModoId = usuario.ModoId,
            AfpId = usuario.AfpId,
            CategoriaId = usuario.CategoriaId,
            ValidaDocumento = usuario.ValidaDocumento,
            FechaFin = usuario.FechaFin,
            FechaPago = usuario.FechaPago,
            FechaInicio = usuario.FechaInicio,
            SueldoBruto = usuario.SueldoBruto,
            EstadoId = usuario.EstadoId,
            Direccion = usuario.Direccion,
            ComunaId = usuario.ComunaId,
            RegionId = usuario.RegionId,
            PaisId = usuario.PaisId,
            CuentaBancariaId = usuario.CuentaBancariaId,
            Banco = usuario != null ? cuentaBancaria.Banco : null,
            TipoCuenta = usuario != null ? cuentaBancaria.TipoCuenta : null,
            NumCuenta = usuario != null ? cuentaBancaria.NumCuenta : null,
        };
    }
}