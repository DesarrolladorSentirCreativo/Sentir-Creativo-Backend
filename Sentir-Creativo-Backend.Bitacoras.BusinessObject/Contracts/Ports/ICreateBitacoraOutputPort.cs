namespace Sentir_Creativo_Backend.Bitacoras.BusinessObject.Contracts.Ports;

public interface ICreateBitacoraOutputPort
{
    ValueTask Handle(int bitacoraId);
}