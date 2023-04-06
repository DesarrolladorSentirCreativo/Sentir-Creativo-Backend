using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Organizaciones;

namespace Sentir_Creativo_Backend.WebApi.Audiencias.Organizaciones;

public static class OrganizacionEndpoints
{
    public static WebApplication UseOrganizacionEndpoints(this WebApplication app)
    {
        app.MapGet("organizaciones/select", async (ISelectOrganizacionController controller) => Results.Ok(await controller.Handle()));

        return app;
    }
}