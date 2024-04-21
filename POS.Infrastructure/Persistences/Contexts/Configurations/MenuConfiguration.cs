using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Infrastructure.Persistences.Contexts.Configurations
{
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasKey(e => e.MenuId).HasName("PK__Menus__C99ED2302352D4A6");

            builder.Property(e => e.Icon)
                .HasMaxLength(50)
                .IsUnicode(false);
            builder.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false);
            builder.Property(e => e.Url)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("URL");
        }
    }
}
