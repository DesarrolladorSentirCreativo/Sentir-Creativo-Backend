using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Motivaciones;

namespace Sentir_Creativo_Backend.WebApi.Audiencias.Motivaciones;

public static class MotivacionEndpoints
{
    public static WebApplication UseMotivacionEndpoints(this WebApplication app)
    {
        app.MapGet("motivaciones/select", async (ISelectMotivacionController controller) => Results.Ok(await controller.Handle()));

        return app;
    }
}