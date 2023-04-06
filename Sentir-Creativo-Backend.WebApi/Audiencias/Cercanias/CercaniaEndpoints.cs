using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Cercanias;

namespace Sentir_Creativo_Backend.WebApi.Audiencias.Cercanias;

public static class CercaniaEndpoints
{
    public static WebApplication UseCercaniaEndpoints(this WebApplication app)
    {
        app.MapGet("cercanias/select", async (ISelectCercaniaController controller) => Results.Ok(await controller.Handle()));

        return app;
    }
}