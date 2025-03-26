using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cadastro.Application.ViewModels
{
    public record class UserViewModel(string name,string email,string password, string comfirmPassWord,string foneNumber, DateTime dateOfBirth);
    
}
