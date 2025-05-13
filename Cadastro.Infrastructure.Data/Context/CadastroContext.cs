using Cadastro.Domain.Entities;
using Cadastro.Infrastructure.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Infrastructure.Data.Context
{
    public class CadastroContext : DbContext 
    {
        public CadastroContext(DbContextOptions<CadastroContext>options)
            : base (options)
        {
                
        }
        public required virtual DbSet<UserEntity> Users { get; set; }
        public required virtual DbSet<FoneNumberEntity> Fonenumbers { get; set; }
        public required virtual DbSet<EmailEntity> Emails { get; set; }
        public required virtual DbSet<AddressEntity> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMapping());
            modelBuilder.ApplyConfiguration(new AddressMapping());
            modelBuilder.ApplyConfiguration(new EmailMapping());
            modelBuilder.ApplyConfiguration(new FoneNumberMapping());

            base.OnModelCreating(modelBuilder);

        }
    }
}
