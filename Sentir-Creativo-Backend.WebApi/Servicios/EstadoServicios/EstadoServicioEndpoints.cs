using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.EstadoServicios;

namespace Sentir_Creativo_Backend.WebApi.Servicios.EstadoServicios;

public static class EstadoServicioEndpoints
{
    public static WebApplication UseServicioEndpoints(this WebApplication app)
    {
        app.MapGet("servicios/select", async (ISelectEstadoServicioController controller) => Results.Ok(await controller.Handle()));

        return app;
    }
}