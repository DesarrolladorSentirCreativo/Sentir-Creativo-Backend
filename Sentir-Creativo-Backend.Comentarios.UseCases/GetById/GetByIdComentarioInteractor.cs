using Senitr_Creativo_Backend.Comentarios.Entities.POCOEntities;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.GetById;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.ViewModels;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.Comentarios.UseCases.GetById;

public class GetByIdComentarioInteractor : IGetByIdComentarioInputPort
{
    private readonly IReadRepository<Comentario, int> _comentarioReadRepository;
    private readonly IReadRepository<UserAdmin,int> _userAdminReadRepository;
    private readonly IGetByIdComentarioOutputPort _outputPort;
    
    public GetByIdComentarioInteractor(
        IReadRepository<Comentario, int> comentarioReadRepository,
        IGetByIdComentarioOutputPort outputPort,
        IReadRepository<UserAdmin,int> userAdminReadRepository)
    {
        _comentarioReadRepository = comentarioReadRepository;
        _outputPort = outputPort;
        _userAdminReadRepository = userAdminReadRepository;
    }
    
    public async ValueTask Handle(int comentarioId)
    {
        var comentario = await _comentarioReadRepository.GetByIdAsync(comentarioId);
        
        if(comentario == null) throw new Exception("El comentario no se encuentra registrado");
        
        
        var userAdmin = await _userAdminReadRepository.GetByIdAsync(comentario.CreatedBy ?? 0);
        
        if(userAdmin == null) throw new Exception("El usuario no se encuentra registrado");
        

        var modelView = new GetByIdComentarioViewModel()
        {
            Id = comentario.Id,
            Descripcion = comentario.Descripcion ?? "",
            FechaCreacion = comentario.PublishedAt,
            Usuario = userAdmin.UserName ?? "Usuario"
        };
        
        await _outputPort.Handle(modelView);

    }
}