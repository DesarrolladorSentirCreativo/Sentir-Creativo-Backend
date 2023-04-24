namespace Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.Create;

public interface ICreateArchivoOutputPort
{
    ValueTask Handle(int archivoId);
}