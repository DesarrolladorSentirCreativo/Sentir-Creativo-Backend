﻿namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Ocacions.Update
{
    public interface IUpdateOcacionInputPort
    {
        ValueTask Handle(UpdateOcacionDto dto);
    }
}
