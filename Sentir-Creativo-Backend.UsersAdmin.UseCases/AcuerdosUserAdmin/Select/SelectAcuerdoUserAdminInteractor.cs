namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.AcuerdosUserAdmin.Select;

public class SelectAcuerdoUserAdminInteractor : ISelectAcuerdoUserAdminInputPort
{
    private readonly IReadRepository<AcuerdoUserAdmin,int> _readRepository;
    private readonly ISelectAcuerdoUserAdminOutputPort _outputPort;

    public SelectAcuerdoUserAdminInteractor(
        IReadRepository<AcuerdoUserAdmin, int> readRepository,
        ISelectAcuerdoUserAdminOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }

    public async ValueTask Handle()
    {
        var spec = new AcuerdoUserAdminActivosSpecification();

        var acuerdos = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectAcuerdoUserAdminViewModel> data = acuerdos
            .Select(p => 
                new SelectAcuerdoUserAdminViewModel()
                {
                    Id = p.Id,
                    Nombre = p.Nombre
                })
            .ToList()
            .AsReadOnly();

        await _outputPort.Handle(data);
    }
}