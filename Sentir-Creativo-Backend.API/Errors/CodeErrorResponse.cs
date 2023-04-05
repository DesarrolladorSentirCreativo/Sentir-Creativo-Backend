using Newtonsoft.Json;

namespace Sentir_Creativo_Backend.API.Errors;

public class CodeErrorResponse
{
    [JsonProperty(PropertyName = "code")]
    public int StatusCode { get; set; }
    public string[]? Message { get; set; }

    public CodeErrorResponse(int statusCode, string[]? message = null)
    {
        StatusCode = statusCode;

        if (message is null)
        {
            Message = new string[0];
            var text = GetDefaultMessageStatusCode(statusCode);
            Message[0] = text;
        }
        else
        {
            Message = message;
        }
    }

    private string GetDefaultMessageStatusCode(int statusCode)
    {
        return statusCode switch
        {
            400 => "El Request enviado tiene errores",
            401 => "No tienes autorizacion para este recurso",
            404 => "No se encontro el recurso solicitado",
            500 => "Se produjon errores en el servidor" ,
            _ => string.Empty
        };
    }
}