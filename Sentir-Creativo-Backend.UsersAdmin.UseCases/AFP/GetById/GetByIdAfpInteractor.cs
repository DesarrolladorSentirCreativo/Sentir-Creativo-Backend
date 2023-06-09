namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.AFP.GetById;

public class GetByIdAfpInteractor : IGetByIdAfpInputPort
{
    private readonly IReadRepository<Afp,int> _readRepository;
    private readonly IGetByIdAfpOutputPort _outputPort;
    
    public GetByIdAfpInteractor(IReadRepository<Afp, int> readRepository,
        IGetByIdAfpOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle(int afpId)
    {
        var spec = new AfpActivoByIdSpecification(afpId);

        var afp = await _readRepository.GetByIdWithSpec(spec);

        if (afp == null) throw new NotFoundException("El afp no se encuentra registrada");
        
        var data = new GetByIdAfpViewModel()
        {
            Id = afp.Id,
            Nombre = afp.Nombre,
            Descripcion = afp.Descripcion,
        };
        
        await _outputPort.Handle(data);
    }
}