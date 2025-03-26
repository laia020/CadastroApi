using Cadastro.Application.Interfaces;
using Cadastro.Application.ViewModels;
using Cadastro.Domain.Contracts.Adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Services
{
    public class UserAppServices : IUserAppServices
    {
        public void add(UserViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<UserViewModel> getById(int userId)
        {
            throw new NotImplementedException();
        }

        public void removeById(int userId)
        {
            throw new NotImplementedException();
        }

        public void updateById(int userId, UserViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task <List<UserViewModel>> getAll()
        {
            throw new NotImplementedException();
        }
    }
}
