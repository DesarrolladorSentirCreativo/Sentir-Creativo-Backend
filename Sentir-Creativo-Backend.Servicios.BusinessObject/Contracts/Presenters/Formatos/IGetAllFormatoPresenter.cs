﻿namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.Formatos
{
    public interface IGetAllFormatoPresenter : IGetAllFormatoOutputPort
    {
        IReadOnlyList<GetAllFormatoViewModel> ViewModels { get; }
    }
}
