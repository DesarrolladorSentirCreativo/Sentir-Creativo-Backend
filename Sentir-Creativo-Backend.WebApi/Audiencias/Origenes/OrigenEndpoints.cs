using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Origenes;

namespace Sentir_Creativo_Backend.WebApi.Audiencias.Origenes;

public static class OrigenEndpoints
{
    public static WebApplication UseOrigenEndpoints(this WebApplication app)
    {
        app.MapGet("origenes/select", async (ISelectOrigenController controller) => Results.Ok(await controller.Handle()));

        return app;
    }
}