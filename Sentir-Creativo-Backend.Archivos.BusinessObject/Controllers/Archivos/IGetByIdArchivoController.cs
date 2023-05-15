using Sentir_Creativo_Backend.Archivos.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.Archivos.BusinessObject.Controllers.Archivos;

public interface IGetByIdArchivoController
{
    ValueTask<GetByIdArchivoViewModel> Handle(int archivoId);
}