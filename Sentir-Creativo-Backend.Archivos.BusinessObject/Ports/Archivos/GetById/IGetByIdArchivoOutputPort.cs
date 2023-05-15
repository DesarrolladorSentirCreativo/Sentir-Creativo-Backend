using Sentir_Creativo_Backend.Archivos.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.GetById;

public interface IGetByIdArchivoOutputPort
{
    ValueTask Handle(GetByIdArchivoViewModel modelView);
}