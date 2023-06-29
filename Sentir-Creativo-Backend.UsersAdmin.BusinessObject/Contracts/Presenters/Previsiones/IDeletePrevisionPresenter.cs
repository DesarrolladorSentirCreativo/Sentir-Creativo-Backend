namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Previsiones;

public interface IDeletePrevisionPresenter : IDeletePrevisionOutputPort
{
    int PrevisionId { get; }
}