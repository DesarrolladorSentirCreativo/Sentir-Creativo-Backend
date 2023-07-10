namespace Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.EstadoServicios
{
    public class GetAllEstadoServicioViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string? Color { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? PublishedAt { get; set; }

    }
}
