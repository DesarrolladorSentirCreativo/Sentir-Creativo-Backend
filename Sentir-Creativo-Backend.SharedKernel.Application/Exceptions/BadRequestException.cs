namespace Sentir_Creativo_Backend.SharedKernel.Application.Exceptions;

public class BadRequestException : ApplicationException
{
    public BadRequestException(string message) : base(message)
    {

    }
}