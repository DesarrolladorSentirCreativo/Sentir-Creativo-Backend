using System.Text;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Sentir_Creativo_Backend.WebExceptionsPresenters;

public class ValidationExceptionHandler : BaseExceptionHandler, IExceptionHandler
{
    public ValueTask Handle(ExceptionContext context)
    {
        var exception = context.Exception as ValidationException;

        StringBuilder builder = new StringBuilder();

        foreach (var failure in exception.Errors)
        {
            builder.AppendLine(
                string.Format("Propiedad: {0}. Error: {1}",
                    failure.PropertyName, failure.ErrorMessage));
        }

        return SetResult(context, 
            StatusCodes.Status400BadRequest, 
            "Error en los datos de entrada", 
            builder.ToString());
    }
}