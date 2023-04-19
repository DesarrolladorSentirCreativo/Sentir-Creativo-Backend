using System.Security.Cryptography;
using System.Text;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace Sentir_Creativo_Backend.SharedKernel.Services.Infrastructure.Services;

public class HashPassword : IHashPassword
{
    public string Handle(string password)
    {
        using (SHA256 sha256Hash = SHA256.Create())
        {
            // Convertir la contraseña en bytes
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

            // Convertir los bytes en una cadena hexadecimal
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }
}