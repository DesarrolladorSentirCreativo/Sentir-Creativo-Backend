namespace Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.Delete;

public interface IDeleteArchivoOutputPort
{
    ValueTask Handle(int archivoId);
}