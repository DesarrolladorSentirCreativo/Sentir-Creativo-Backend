using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.EFCore.Repositories.Configurations;

public class UserAdminConfiguration : IEntityTypeConfiguration<UserAdmin>
{
    public void Configure(EntityTypeBuilder<UserAdmin> builder)
    {
            builder.ToTable("users-permissions_user");
                        
            builder.HasKey(p => p.Id).HasName("id");
            builder.Property(p => p.Email).IsRequired().HasMaxLength(255).HasColumnName("email");
            builder.Property(p => p.UserName).HasMaxLength(255).HasColumnName("username");
            builder.Property(p => p.ConfirmationToken).HasMaxLength(255).HasColumnName("confirmationToken");
            builder.Property(p => p.ResetPasswordToken).HasMaxLength(255).HasColumnName("resetPasswordToken");
            builder.Property(p => p.Password).HasMaxLength(255).HasColumnName("password");
            builder.Property(p => p.Confirmed).HasColumnName("confirmed");
            builder.Property(p => p.Blocked).HasColumnName("blocked");
            builder.Property(p => p.RoleId).HasColumnName("role");
            builder.Property(p => p.Provider).HasColumnName("provider");
            builder.Property(p => p.CreatedAt).HasColumnName("created_at");
            builder.Property(p => p.UpdatedAt).HasColumnName("updated_at");
            builder.Property(p => p.CreatedBy).HasColumnName("created_by");
            builder.Property(p => p.UpdatedBy).HasColumnName("updated_by");


    }
}