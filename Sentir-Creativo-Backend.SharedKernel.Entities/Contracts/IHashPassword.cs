namespace Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

public interface IHashPassword
{
    string Handle(string password);
}