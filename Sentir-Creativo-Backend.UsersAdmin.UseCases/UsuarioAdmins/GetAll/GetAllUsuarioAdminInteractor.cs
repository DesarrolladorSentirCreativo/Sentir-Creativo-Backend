using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.UsuarioAdmins;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.UsuarioAdmins.GetAll;

public class GetAllUsuarioAdminInteractor : IGetAllUsuarioAdminInputPort
{
    private readonly IReadRepository<UsuarioAdmin,int> _readRepository;
    private readonly IGetAllUsuarioAdminOutputPort _outputPort;
    
    public GetAllUsuarioAdminInteractor(
        IReadRepository<UsuarioAdmin, int> readRepository,
        IGetAllUsuarioAdminOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new UsuarioAdminActivosSpecification();

        var roles = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<GetAllUsuarioAdminViewModel> data = roles
            .Select(p => 
                new GetAllUsuarioAdminViewModel()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    Apellidos = p.Apellidos,
                    Email = p.Email,
                    PrevisionId = p.PrevisionId,
                    ModoId = p.ModoId,
                    AfpId = p.AfpId,
                    CategoriaId = p.CategoriaId,
                    FechaPago = p.FechaPago,
                    FechaFin = p.FechaFin,
                    FechaInicio = p.FechaInicio,
                    SueldoBruto = p.SueldoBruto,
                    EstadoId = p.EstadoId,
                    ValidaDocumento = p.ValidaDocumento,
                    TipoDocumento = p.TipoDocumento,
                    NumDocumento = p.NumDocumento,
                    Direccion = p.Direccion,
                    ComunaId = p.ComunaId,
                    RegionId = p.RegionId,
                    PaisId = p.PaisId,
                    PublishedAt = p.PublishedAt
                })
            .ToList()
            .AsReadOnly();

        await _outputPort.Handle(data);
    }
}