﻿using Sentir_Creativo_Backend.Servicios.BusinessObject.Dtos.Ocacions;


namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Ocacions.Create
{
    public interface ICreateOcacionInputPort
    {
        ValueTask Handle(CreateOcacionDto dto);
    }
}
