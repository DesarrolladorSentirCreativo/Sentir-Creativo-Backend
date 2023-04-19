using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.EFCore.Repositories.Configurations;

public class UserAdminConfiguration : IEntityTypeConfiguration<UserAdmin>
{
    public void Configure(EntityTypeBuilder<UserAdmin> builder)
    {
            builder.ToTable("strapi_administrator");
                        
            builder.HasKey(p => p.Id).HasName("id");
            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(255).HasColumnName("firstname");
            builder.Property(p => p.LastName).IsRequired().HasMaxLength(255).HasColumnName("lastname");
            builder.Property(p => p.Email).IsRequired().HasMaxLength(255).HasColumnName("email");
            builder.Property(p => p.UserName).HasMaxLength(255).HasColumnName("username");
            builder.Property(p => p.RegistrationToken).HasMaxLength(255).HasColumnName("registrationToken");
            builder.Property(p => p.ResetPasswordToken).HasMaxLength(255).HasColumnName("resetPasswordToken");
            builder.Property(p => p.PreferedLanguage).HasMaxLength(255).HasColumnName("preferedLanguage");
            builder.Property(p => p.Password).HasMaxLength(255).HasColumnName("password");
            builder.Property(p => p.IsActive).HasColumnName("isActive");
            builder.Property(p => p.IsBlocked).HasColumnName("blocked");


    }
}