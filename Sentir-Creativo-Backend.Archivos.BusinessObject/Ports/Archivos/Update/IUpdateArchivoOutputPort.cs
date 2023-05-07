namespace Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.Update;

public interface IUpdateArchivoOutputPort
{
    ValueTask Handle(int archivoId);
}