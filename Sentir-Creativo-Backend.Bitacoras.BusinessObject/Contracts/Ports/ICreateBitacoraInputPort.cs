using System.Reflection.Metadata;
using Sentir_Creativo_Backend.Bitacoras.BusinessObject.DTOs;

namespace Sentir_Creativo_Backend.Bitacoras.BusinessObject.Contracts.Ports;

public interface ICreateBitacoraInputPort
{
    ValueTask Handle(CreateBitacoraDto dto);
}