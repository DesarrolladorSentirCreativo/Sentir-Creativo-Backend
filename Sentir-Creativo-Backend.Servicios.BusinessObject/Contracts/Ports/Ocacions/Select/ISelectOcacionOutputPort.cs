namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Ocacions.Select
{
    public interface ISelectOcacionOutputPort
    {
        ValueTask Handle(IReadOnlyList<SelectOcacionModelView> ModelViews);
    }
}
