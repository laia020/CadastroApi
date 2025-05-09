using Cadastro.Domain.Contracts.Repositories;
using Cadastro.Domain.Entities;
using Cadastro.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Infrastructure.Data.Repositories
{
    public class UserRepository : Repository<UserEntity>, IUserRepository
    {
        public UserRepository(CadastroContext context) : base(context)
        {
        }
    }
}
