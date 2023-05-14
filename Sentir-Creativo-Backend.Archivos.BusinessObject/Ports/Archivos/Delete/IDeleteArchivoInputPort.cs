namespace Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.Delete;

public interface IDeleteArchivoInputPort
{
    ValueTask Handle(int archivoId);
}