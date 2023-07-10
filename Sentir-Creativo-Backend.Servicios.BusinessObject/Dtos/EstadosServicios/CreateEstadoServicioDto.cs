namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Dtos.EstadosServicios
{
    public class CreateEstadoServicioDto
    {
        public string Nombre { get; set; }
        public string? Color { get; set; }
        public string? Descripcion { get; set; }
        public int UserId { get; set; }
    }
}
