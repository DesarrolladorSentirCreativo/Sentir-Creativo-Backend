using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.AcuerdosUserAdmin.GetById;

public class GetByIdAcuerdoUserAdminInteractor : IGetByIdAcuerdoUserAdminInputPort
{
    private readonly IReadRepository<AcuerdoUserAdmin,int> _readRepository;
    private readonly IGetByIdAcuerdoUserAdminOutputPort _outputPort;
    
    public GetByIdAcuerdoUserAdminInteractor(
        IReadRepository<AcuerdoUserAdmin, int> readRepository, 
        IGetByIdAcuerdoUserAdminOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle(int acuerdoId)
    {
        var spec = new AcuerdoUserAdminActivoByIdSpecification(acuerdoId);

        var acuerdo = await _readRepository.GetByIdWithSpec(spec);

        if (acuerdo == null) throw new Exception("El acuerdo no se encuentra registrada");

        var data = new GetByIdAcuerdoUserAdminViewModel()
        {
            Id = acuerdo.Id,
            Nombre = acuerdo.Nombre,
            Descripcion = acuerdo.Descripcion,
        };
        
        await _outputPort.Handle(data);
    }
}