namespace Sentir_Creativo_Backend.SharedKernel.Application.Exceptions;

public class NotFoundException : ApplicationException
{
    public NotFoundException(string message, object key) : base($"Entity \"{key}\" ({key}) no fue encontrado")
    {
        
    }
}