using Cadastro.Domain.Entities;
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
        public virtual DbSet<UserEntity> users { get; set; }
        //Fazer a DbSet de cada entity email/adress/fone
    }
}
