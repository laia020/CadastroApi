using Cadastro.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Interfaces
{
    public interface IUserAppServices
    {
        void add(UserViewModel model);
        Task<UserViewModel> getById(int userId);
        Task<List<UserViewModel>> getAll ();
        void removeById(int userId);
        void updateById(int userId, UserViewModel model);
    }
}
