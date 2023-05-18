using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Services;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Audiencias;

namespace Sentir_Creativo_Backend.Audiencias.Make.Repositories.Services.Audiencia;

public class UpdateAudienciaService : IUpdateAudienciaService
{
    private readonly HttpClient _httpClient;

    public UpdateAudienciaService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async ValueTask Handle(UpdateAudienciaViewModel viewModel)
    {
        var cuponDescuentosJson = JsonConvert.SerializeObject(viewModel.CuponDescuentos);
        var difusionesJson = JsonConvert.SerializeObject(viewModel.Difusiones);
        var archivosJson = JsonConvert.SerializeObject(viewModel.Archivos);
        var comentariosJson = JsonConvert.SerializeObject(viewModel.Comentarios);
        
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
            { "difusiones", difusionesJson },
            { "comentarios", comentariosJson },
            { "archivos", archivosJson },
            
        });
        
        var url = "https://hook.us1.make.com/7cbpaf2xpmviqkc9qnwf2v3dwdyi3uuw" + queryString;
        await _httpClient.GetAsync(url);
    }
}