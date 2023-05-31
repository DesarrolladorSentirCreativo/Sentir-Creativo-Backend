using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.EFCore.Repositories.Configurations;

public class AccesoConfiguration : IEntityTypeConfiguration<Acceso>
{
    public void Configure(EntityTypeBuilder<Acceso> builder)
    {
        throw new NotImplementedException();
    }
}