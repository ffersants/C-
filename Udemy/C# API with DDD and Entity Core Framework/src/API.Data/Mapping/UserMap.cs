using API.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<UserEntity>
    {
        //schema da table
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("User");
            builder.HasKey(u => u.Id);

            builder.HasIndex(p => p.Email)
                    .IsUnique();
            builder.Property(u => u.Name)
                    .IsRequired()
                    .HasMaxLength(60);
            builder.Property(u => u.Email)
            .HasMaxLength(100);
        }
    }
}
