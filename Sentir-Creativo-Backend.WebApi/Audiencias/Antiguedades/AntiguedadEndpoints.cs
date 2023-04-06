using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Antiguedades;

namespace Sentir_Creativo_Backend.WebApi.Audiencias.Antiguedades;

public static class AntiguedadEndpoints
{
    public static WebApplication UseAntiguedadEndpoints(this WebApplication app)
    {
        app.MapGet("antiguedades/select", async (ISelectAntiguedadController controller) => Results.Ok(await controller.Handle()));

        return app;
    }
}