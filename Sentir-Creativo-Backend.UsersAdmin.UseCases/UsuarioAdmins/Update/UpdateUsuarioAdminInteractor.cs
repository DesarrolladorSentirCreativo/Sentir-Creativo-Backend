using FluentValidation;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.UsuarioAdmins.Update;

public class UpdateUsuarioAdminInteractor : IUpdateUsuarioAdminInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<UsuarioAdmin,int> _usuarioAdminReadRepository;
    private readonly IReadRepository<CuentaBancaria,int> _cuentaBancariaReadRepository;
    private readonly IUpdateUsuarioAdminOutputPort _outputPort;
    private readonly IEnumerable<IValidator<UpdateUsuarioAdminDto>> _validators;
    
    public UpdateUsuarioAdminInteractor(
        IUnitOfWork unitOfWork, 
        IReadRepository<UsuarioAdmin, int> usuarioAdminReadRepository,
        IReadRepository<CuentaBancaria, int> cuentaBancariaReadRepository,
        IUpdateUsuarioAdminOutputPort outputPort,
        IEnumerable<IValidator<UpdateUsuarioAdminDto>> validators)
    {
        _unitOfWork = unitOfWork;
        _usuarioAdminReadRepository = usuarioAdminReadRepository;
        _cuentaBancariaReadRepository = cuentaBancariaReadRepository;
        _outputPort = outputPort;
        _validators = validators;
    }
    
    
    public async ValueTask Handle(UpdateUsuarioAdminDto dto)
    {
       //validamos los datos
        await Validator<UpdateUsuarioAdminDto>.Validate(dto, _validators);

        //validamos que no exista un usuario con el mismo email o numero de documento
        var spec = new UsuarioAdminActivoByEmailAndNumDocumentoSpecification(dto.Email, dto.NumDocumento);

        var existUsuario = await _usuarioAdminReadRepository.GetByIdWithSpec(spec);

        if (existUsuario != null)
        {
            if(existUsuario.Id != dto.Id) throw new Exception("Ya existe un usuario con el mismo email o numero de documento");
        }

        //actualizar datos de los usuarios
        var specUsuario = new UsuarioAdminActivoByIdSpecification(dto.Id);

        var usuario = await _usuarioAdminReadRepository.GetByIdWithSpec(specUsuario);


        usuario.Nombre = dto.Nombre;
        usuario.Apellidos = dto.Apellidos;
        usuario.Email = dto.Email;
        usuario.PrevisionId = dto.PrevisionId;
        usuario.ModoId = dto.ModoId;
        usuario.AfpId = dto.AfpId;
        usuario.CategoriaId = dto.CategoriaId;
        usuario.FechaPago = dto.FechaPago;
        usuario.FechaFin = dto.FechaFin;
        usuario.FechaInicio = dto.FechaInicio;
        usuario.SueldoBruto = dto.SueldoBruto;
        usuario.EstadoId = dto.EstadoId;
        usuario.Password = dto.Password; 
        usuario.ValidaDocumento = dto.ValidaDocumento;
        usuario.TipoDocumento = dto.TipoDocumento; 
        usuario.NumDocumento = dto.NumDocumento;
        usuario.Direccion = dto.Direccion;
        usuario.ComunaId = dto.ComunaId;
        usuario.RegionId = dto.RegionId;
        usuario.PaisId = dto.PaisId;
        usuario.UpdatedAt = DateTime.Now;
        usuario.UpdatedBy = dto.UserId;

        _unitOfWork.WriteRepository<UsuarioAdmin,int>().UpdateEntity(usuario);

        //actualizar datos cuenta bancaria
        var specCuentaBancaria = new CuentaBancariaActivoByIdSpecification(usuario.CuentaBancariaId);
        
        var cuentaBancaria = await _cuentaBancariaReadRepository.GetByIdWithSpec(specCuentaBancaria);

        cuentaBancaria.Banco = dto.Banco;
        cuentaBancaria.TipoCuenta = dto.TipoCuenta;
        cuentaBancaria.NumCuenta = dto.NumCuenta;
        cuentaBancaria.UpdatedAt = DateTime.Now;
        cuentaBancaria.UpdatedBy = dto.UserId;

        _unitOfWork.WriteRepository<CuentaBancaria, int>().UpdateEntity(cuentaBancaria);
        
        //eliminar los roles
        _unitOfWork.WriteRepository<UsuarioRol,int>().DeleteWhere(p => p.UsuarioId == dto.Id);
        
        //eliminar los acuerdos
        _unitOfWork.WriteRepository<UsuarioAcuerdo,int>().DeleteWhere(p => p.UsuarioId == dto.Id);
        
        //eliminar los privilegios
        _unitOfWork.WriteRepository<UsuarioPrivilegio,int>().DeleteWhere(p => p.UsuarioId == dto.Id);
        
        //eliminar los archivos
        _unitOfWork.WriteRepository<UsuarioArchivo,int>().DeleteWhere(p => p.UsuarioId == dto.Id);
        
        //eliminar los comentarios
        _unitOfWork.WriteRepository<UsuarioComentario,int>().DeleteWhere(p => p.UsuarioId == dto.Id);
        
        //eliminar las sucursales
        _unitOfWork.WriteRepository<UsuarioSucursal,int>().DeleteWhere(p => p.UsuarioId == dto.Id);
        
        
        //guardamos todos los roles
        foreach (var rol in dto.Roles)
        {
            _unitOfWork.WriteRepository<UsuarioRol,int>().AddEntity(new UsuarioRol()
            {
                UsuarioId = usuario.Id,
                RolId = rol.RolId
            });
        }
        
        //guardamos los acuerdos
        foreach (var acuerdo in dto.Acuerdos)
        {
            _unitOfWork.WriteRepository<UsuarioAcuerdo,int>().AddEntity(new UsuarioAcuerdo()
            {
                UsuarioId = usuario.Id,
                AcuerdoId = acuerdo.AcuerdoId
            });
        }
        
        //guardamos los privilegios
        foreach (var privilegio in dto.Privilegios)
        {
            _unitOfWork.WriteRepository<UsuarioPrivilegio,int>().AddEntity(new UsuarioPrivilegio()
            {
                UsuarioId = usuario.Id,
                PrivilegioId = privilegio.PrivilegioId
            });
        }
        
        //guardamos los archivos
        foreach (var archivo in dto.Archivos)
        {
            _unitOfWork.WriteRepository<UsuarioArchivo,int>().AddEntity(new UsuarioArchivo()
            {
                UsuarioId = usuario.Id,
                ArchivoId = archivo.ArchivoId
            });
        }
        
        //guardamos los comentarios
        foreach (var comentario in dto.Comentarios)
        {
            _unitOfWork.WriteRepository<UsuarioComentario,int>().AddEntity(new UsuarioComentario()
            {
                UsuarioId = usuario.Id,
                ComentarioId = comentario.ComentarioId
            });
        }
        
        //guardamos los sucursales
        foreach (var sucursal in dto.Sucursales)
        {
            _unitOfWork.WriteRepository<UsuarioSucursal,int>().AddEntity(new UsuarioSucursal()
            {
                UsuarioId = usuario.Id,
                SucursalId = sucursal.SucursalId
            });
        }

        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo insertar el record de usuarios");
        }

        await _outputPort.Handle(usuario.Id);
    }
}