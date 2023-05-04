using Sentir_Creativo_Backend.Comentarios.BusinessObjects.Ports.GetById;
using Sentir_Creativo_Backend.Comentarios.BusinessObjects.ViewModels;

namespace Sentir_Creativo_Backend.Comentarios.BusinessObjects.Presenters;

public interface IGetByIdComentarioPresenter : IGetByIdComentarioOutputPort
{
    GetByIdComentarioViewModel GetByIdComentarioViewModel { get;}
}