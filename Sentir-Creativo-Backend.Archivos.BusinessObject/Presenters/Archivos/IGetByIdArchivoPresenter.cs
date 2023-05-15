using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.GetById;
using Sentir_Creativo_Backend.Archivos.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.Archivos.BusinessObject.Presenters.Archivos;

public interface IGetByIdArchivoPresenter : IGetByIdArchivoOutputPort
{
    GetByIdArchivoViewModel GetByIdArchivoViewModel { get; }
}