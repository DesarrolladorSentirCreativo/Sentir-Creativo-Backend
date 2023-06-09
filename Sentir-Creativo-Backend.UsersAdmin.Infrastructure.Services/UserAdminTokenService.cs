using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Services;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.Infrastructure.Services;

public class UserAdminTokenService : IUserAdminTokenService
{
    private readonly IConfiguration _configuration;
    
    public UserAdminTokenService(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    public string GenerateToken(UserAdmin userAdmin)
    {
        var claims = new[]
        {
            new Claim(ClaimTypes.Name, userAdmin.UserName ?? "Usuario"),
            new Claim(ClaimTypes.Email, userAdmin.Email)
        };
        
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("JWT:Key").Value));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        var securityToken = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.Now.AddDays(30),
            signingCredentials: creds);

        string token = new JwtSecurityTokenHandler().WriteToken(securityToken);
        
        return token;
    }

    public bool ComparePassword(string password, string hashedPassword)
    {
        return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
    }

    public string EncryptPassword(string password)
    {
       return BCrypt.Net.BCrypt.HashPassword(password);
    }

    public string GenerateTokenAdmin(UsuarioAdmin userAdmin)
    {
        var claims = new[]
       {
            new Claim(ClaimTypes.Name, userAdmin.Alias ?? "Usuario"),
            new Claim(ClaimTypes.Email, userAdmin.Email)
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("JWT:Key").Value));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        var securityToken = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.Now.AddDays(30),
            signingCredentials: creds);

        string token = new JwtSecurityTokenHandler().WriteToken(securityToken);

        return token;
    }
}