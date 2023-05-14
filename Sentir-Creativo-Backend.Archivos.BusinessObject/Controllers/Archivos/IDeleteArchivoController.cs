namespace Sentir_Creativo_Backend.Archivos.BusinessObject.Controllers.Archivos;

public interface IDeleteArchivoController
{
    ValueTask<int> Handle(int archivoId);
}