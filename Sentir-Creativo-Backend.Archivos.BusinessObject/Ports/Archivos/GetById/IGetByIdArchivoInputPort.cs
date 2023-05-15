namespace Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.GetById;

public interface IGetByIdArchivoInputPort
{
    ValueTask Handle(int archivoId);
}