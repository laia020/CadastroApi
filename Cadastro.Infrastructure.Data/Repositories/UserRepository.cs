using Cadastro.Domain.Contracts.Repositories;
using Cadastro.Domain.Entities;
using Cadastro.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Infrastructure.Data.Repositories
{
    public class UserRepository : Repository<UserEntity>, IUserRepository
    {
        private readonly CadastroContext _context;
        public UserRepository(CadastroContext context) : base(context)
        {
            _context = context;
        }


        public override IEnumerable<UserEntity> GetAll()
        {
            return _context.Users.Include(p => p.Email).Include(p => p.Address).Include(p => p.FoneNumber);
        }

        public override UserEntity GetById(int id)
        {
            return _context.Users.Include(p => p.Email).Include(p => p.Address).Include(p => p.FoneNumber).FirstOrDefault(p => p.Id == id);
        }
    }
}
