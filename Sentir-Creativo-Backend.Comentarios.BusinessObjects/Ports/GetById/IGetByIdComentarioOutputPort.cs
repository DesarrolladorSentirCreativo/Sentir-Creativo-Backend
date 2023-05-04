using Sentir_Creativo_Backend.Comentarios.BusinessObjects.ViewModels;

namespace Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.GetById;

public interface IGetByIdComentarioOutputPort
{
    ValueTask Handle(GetByIdComentarioViewModel viewModel);
}