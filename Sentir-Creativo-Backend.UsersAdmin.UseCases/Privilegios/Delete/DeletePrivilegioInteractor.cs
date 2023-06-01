using FluentValidation;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Privilegios.Delete;

public class DeletePrivilegioInteractor : IDeletePrivilegioInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<Privilegio,string> _privilegioReadRepository;
    private readonly IReadRepository<PrivilegioAcceso, int> _privilegioAccesoReadRepository;
    private readonly IUpdatePrivilegioOutputPort _outputPort;

    public DeletePrivilegioInteractor(IUnitOfWork unitOfWork,
        IReadRepository<Privilegio,string> privilegioReadRepository,
        IReadRepository<PrivilegioAcceso,int> privilegioAccesoReadRepository,
        IUpdatePrivilegioOutputPort outputPort)
    {
        _unitOfWork = unitOfWork;
        _privilegioReadRepository = privilegioReadRepository;
        _privilegioAccesoReadRepository = privilegioAccesoReadRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle(string privilegioId)
    {
      

        var spec = new PrivilegioActivoByIdSpecification(privilegioId);

        var privilegio = await _privilegioReadRepository.GetByIdWithSpec(spec);

        if (privilegio == null) throw new Exception("El privilegio no se encuentra registrado");

        privilegio.Activo = false;

        _unitOfWork.WriteRepository<Privilegio,string>().UpdateEntity(privilegio);
        
        var privilegioAccesoSpec = new PrivilegioAccesoByPrivilegioIdSpecification(privilegio.Id);
        
        //buscanos los accesos del privilegio
        var privilegiosAccesos = await _privilegioAccesoReadRepository.GetAllWithSpec(privilegioAccesoSpec);

        //eliminamos los accesos antiguos
        foreach (var privilegioAcceso in privilegiosAccesos)
        {
            _unitOfWork.WriteRepository<Acceso,string>().DeleteWhere(x => x.Id == privilegioAcceso.AccesoId);
        }
        
        //eliminamos los privilegios accesos
        _unitOfWork.WriteRepository<PrivilegioAcceso,int>().DeleteWhere(x => x.PrivilegioId == privilegio.Id);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo eliminar el record de privilegios");
        }

        await _outputPort.Handle(privilegio.Id);
    }
}