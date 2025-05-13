using Cadastro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Infrastructure.Data.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id").IsRequired().ValueGeneratedOnAdd();

            builder.Property(x => x.Name).HasColumnName("Name").HasColumnType("varchar(50)");

            builder.Property(x => x.Password).HasColumnName("Password").IsRequired().HasColumnType("varchar(50)");
            builder.Property(x => x.ConfirmPassword).HasColumnName("ConfirmPassword").HasColumnType("varchar(50)");

            builder.Property(x => x.DateBirthday).HasColumnType("datetime");

            builder.HasMany(x => x.Email).WithOne(x => x.User).HasForeignKey(x => x.UserId);

            builder.HasMany(x => x.FoneNumber).WithOne(x => x.User).HasForeignKey(x => x.UserId);

            builder.HasMany(x => x.Address).WithOne(x => x.User).HasForeignKey(x => x.UserId);

        }
    }
}
