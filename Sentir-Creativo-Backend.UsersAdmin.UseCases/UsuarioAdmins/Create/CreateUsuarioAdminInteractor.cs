using FluentValidation;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.Create;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.UsuarioAdmins.Create;

public class CreateUsuarioAdminInteractor : ICreateUsuarioAdminInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<UsuarioAdmin,int> _readRepository;
    private readonly ICreateUsuarioAdminOutputPort _outputPort;
    private readonly IEnumerable<IValidator<CreateUsuarioAdminDto>> _validators;


    public CreateUsuarioAdminInteractor(
        IUnitOfWork unitOfWork, 
        IReadRepository<UsuarioAdmin, int> readRepository,
        ICreateUsuarioAdminOutputPort outputPort,
        IEnumerable<IValidator<CreateUsuarioAdminDto>> validators)
    {
        _unitOfWork = unitOfWork;
        _readRepository = readRepository;
        _outputPort = outputPort;
        _validators = validators;
    }


    public async ValueTask Handle(CreateUsuarioAdminDto dto)
    {
        //validamos los datos
        await Validator<CreateUsuarioAdminDto>.Validate(dto, _validators);

        //validamos que no exista un usuario con el mismo email o numero de documento
        var spec = new UsuarioAdminActivoByEmailAndNumDocumentoSpecification(dto.Email, dto.NumDocumento);

        var existUsuario = await _readRepository.GetByIdWithSpec(spec);
        
        if(existUsuario != null) throw new Exception("Ya existe un usuario con el mismo email o numero de documento");

        var usuario = new UsuarioAdmin()
        {
            Nombre = dto.Nombre,
            Apellidos = dto.Apellidos,
            Email = dto.Email,
            PrevisionId = dto.PrevisionId,
            ModoId = dto.ModoId,
            AfpId = dto.AfpId,
            CategoriaId = dto.CategoriaId,
            FechaPago = dto.FechaPago,
            FechaFin = dto.FechaFin,
            FechaInicio = dto.FechaInicio,
            SueldoBruto = dto.SueldoBruto,
            EstadoId = dto.EstadoId,
            Password = dto.Password,
            ValidaDocumento = dto.ValidaDocumento,
            TipoDocumento = dto.TipoDocumento,
            NumDocumento = dto.NumDocumento,
            Direccion = dto.Direccion,
            ComunaId = dto.ComunaId,
            RegionId = dto.RegionId,
            PaisId = dto.PaisId,
            PublishedAt = DateTime.Now,
            CreatedAt = DateTime.Now,
            CreatedBy = dto.UserId,
            Activo = true
        };

        //creamos la cuenta bancaria
        var cuentaBancaria = new CuentaBancaria()
        {
            Banco = dto.Banco,
            TipoCuenta = dto.TipoCuenta,
            NumCuenta = dto.NumCuenta,
            Activo = true,
            CreatedAt = DateTime.Now,
            CreatedBy = dto.UserId,
            PublishedAt = DateTime.Now
        };

        _unitOfWork.WriteRepository<CuentaBancaria, int>().AddEntity(cuentaBancaria);

        await _unitOfWork.Complete();
        
        usuario.CuentaBancariaId = cuentaBancaria.Id;
        
        //creamos el usuario
        _unitOfWork.WriteRepository<UsuarioAdmin, int>().AddEntity(usuario);
        
        await _unitOfWork.Complete();
        
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