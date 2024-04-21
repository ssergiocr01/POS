using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Infrastructure.Persistences.Contexts.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(e => e.RoleId).HasName("PK__Roles__8AFACE1A8C4EE4C2");

            builder.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
