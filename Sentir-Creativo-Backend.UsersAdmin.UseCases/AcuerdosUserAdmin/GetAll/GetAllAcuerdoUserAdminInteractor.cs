using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AcuerdosUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.AcuerdosUserAdmin.GetAll;

public class GetAllAcuerdoUserAdminInteractor : IGetAllAcuerdoUserAdminInputPort
{
    private readonly IReadRepository<AcuerdoUserAdmin,int> _readRepository;
    private readonly IGetAllAcuerdoUserAdminOutputPort _outputPort;

    public GetAllAcuerdoUserAdminInteractor(
        IReadRepository<AcuerdoUserAdmin, int> readRepository, 
        IGetAllAcuerdoUserAdminOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }

    public async ValueTask Handle()
    {
        var spec = new AcuerdoUserAdminActivosSpecification();

        var acuerdos = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<GetAllAcuerdoUserAdminViewModel> data = acuerdos
            .Select(p => 
                new GetAllAcuerdoUserAdminViewModel()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    Descripcion = p.Descripcion,

                })
            .ToList()
            .AsReadOnly();

        await _outputPort.Handle(data);
    }
}