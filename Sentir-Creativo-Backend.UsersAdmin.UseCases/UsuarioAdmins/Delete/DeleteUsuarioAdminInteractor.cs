using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.Entities.Exceptions;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.UsuarioAdmins.Delete;

public class DeleteUsuarioAdminInteractor : IDeleteUsuarioAdminInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<UsuarioAdmin,int> _usuarioAdminReadRepository;
    private readonly IReadRepository<CuentaBancaria,int> _cuentaBancariaReadRepository;
    private readonly IDeleteUsuarioAdminOutputPort _outputPort;

    public DeleteUsuarioAdminInteractor(
        IUnitOfWork unitOfWork,
        IReadRepository<UsuarioAdmin, int> usuarioAdminReadRepository, 
        IReadRepository<CuentaBancaria, int> cuentaBancariaReadRepository, 
        IDeleteUsuarioAdminOutputPort outputPort)
    {
        _unitOfWork = unitOfWork;
        _usuarioAdminReadRepository = usuarioAdminReadRepository;
        _cuentaBancariaReadRepository = cuentaBancariaReadRepository;
        _outputPort = outputPort;
    }

    public async ValueTask Handle(int usuarioAdminId)
    {
        
        //actualizar datos de los usuarios
        var specUsuario = new UsuarioAdminActivoByIdSpecification(usuarioAdminId);

        var usuario = await _usuarioAdminReadRepository.GetByIdWithSpec(specUsuario);

        if (usuario == null) throw new NotFoundException("El usuario no se encuntra registrado");

        usuario.Activo = false;

        _unitOfWork.WriteRepository<UsuarioAdmin,int>().UpdateEntity(usuario);

        //actualizar datos cuenta bancaria
        var specCuentaBancaria = new CuentaBancariaActivoByIdSpecification(usuario.CuentaBancariaId);
        
        var cuentaBancaria = await _cuentaBancariaReadRepository.GetByIdWithSpec(specCuentaBancaria);

        cuentaBancaria.Activo = false;

        _unitOfWork.WriteRepository<CuentaBancaria, int>().UpdateEntity(cuentaBancaria);
        
        //eliminar los roles
        _unitOfWork.WriteRepository<UsuarioRol,int>().DeleteWhere(p => p.UsuarioId == usuarioAdminId);
        
        //eliminar los acuerdos
        _unitOfWork.WriteRepository<UsuarioAcuerdo,int>().DeleteWhere(p => p.UsuarioId == usuarioAdminId);
        
        //eliminar los privilegios
        _unitOfWork.WriteRepository<UsuarioPrivilegio,int>().DeleteWhere(p => p.UsuarioId == usuarioAdminId);
        
        //eliminar los archivos
        _unitOfWork.WriteRepository<UsuarioArchivo,int>().DeleteWhere(p => p.UsuarioId == usuarioAdminId);
        
        //eliminar los comentarios
        _unitOfWork.WriteRepository<UsuarioComentario,int>().DeleteWhere(p => p.UsuarioId == usuarioAdminId);
        
        //eliminar las sucursales
        _unitOfWork.WriteRepository<UsuarioSucursal,int>().DeleteWhere(p => p.UsuarioId == usuarioAdminId);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo eliminar el record de usuarios");
        }

        await _outputPort.Handle(usuario.Id);
    }
}