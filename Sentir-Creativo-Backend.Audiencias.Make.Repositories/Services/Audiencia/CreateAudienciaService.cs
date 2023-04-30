using System.Text;
using System.Web;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Services;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;

namespace Sentir_Creativo_Backend.Audiencias.Make.Repositories.Services.Audiencia;

public class CreateAudienciaService : ICreateAudienciaService
{
    private readonly HttpClient _httpClient;

    public CreateAudienciaService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async ValueTask Handle(CreateAudienciaViewModel viewModel)
    {
        var cuponDescuentosJson = JsonConvert.SerializeObject(viewModel.CuponDescuentos);
        var difusionesJson = JsonConvert.SerializeObject(viewModel.Difusiones);
        
        // Convierte los parámetros en una cadena de consulta
        var queryString = QueryHelpers.AddQueryString("", new Dictionary<string,string>
        {
            { "id", viewModel.Id.ToString() },
            { "nombre", viewModel.Nombre },
            { "email", viewModel.Email },
            { "celular", viewModel.Celular.ToString() },
            { "organizacionId", viewModel.OrganizacionId.ToString() },
            { "profesion", viewModel.Profesion },
            { "cercaniaId", viewModel.CercaniaId.ToString() },
            { "origenId", viewModel.OrigenId.ToString()},
            { "departamento", viewModel.Departamento},
            { "antiguedadId", viewModel.AntiguedadId.ToString() },
            { "motivacionId", viewModel.MotivacionId.ToString() },
            { "apellido", viewModel.Apellido},
            { "cargo", viewModel.Cargo},
            { "estadoAudienciaId", viewModel.EstadoAudienciaId.ToString()},
            { "prefijoId", viewModel.PrefijoId.ToString()},
            { "email2", viewModel.Email2},
            { "destacado", viewModel.Destacado.ToString()},
            { "activo", viewModel.Activo.ToString()},
            { "publishedAt", viewModel.PublishedAt.ToString()},
            { "cuponDescuentos",cuponDescuentosJson},
            { "difusiones", difusionesJson}
            
        });
        
        var url = "https://hook.us1.make.com/c5z60wuhoslgkerkhv1cj2z3we6tro8u" + queryString;
        var response = await _httpClient.GetAsync(url);
    }
}