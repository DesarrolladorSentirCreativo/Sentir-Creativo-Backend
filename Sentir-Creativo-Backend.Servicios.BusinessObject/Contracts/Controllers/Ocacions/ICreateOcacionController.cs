namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.Ocacions
{
    public  interface ICreateOcacionController
    {
        ValueTask<int> Handle(CreateOcacionDto dto);
        
    }
}
