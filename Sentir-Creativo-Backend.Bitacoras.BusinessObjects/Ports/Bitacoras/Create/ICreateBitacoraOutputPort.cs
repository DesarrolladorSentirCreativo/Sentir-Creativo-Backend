namespace Sentir_Creativo_Backend.Bitacoras.BusinessObjects.Ports.Bitacoras.Create;

public interface ICreateBitacoraOutputPort
{
    ValueTask Handle(int bitacoraId);
}