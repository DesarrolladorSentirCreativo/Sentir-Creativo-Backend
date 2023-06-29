namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Previsiones;

public interface ICreatePrevisionPresenter : ICreatePrevisionOutputPort
{
    int PrevisionId { get; }
}