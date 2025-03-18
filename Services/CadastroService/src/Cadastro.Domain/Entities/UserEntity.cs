using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Entities
{
    public class UserEntity
    {
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string comfirmPassWord { get; set; }
        public string foneNumber { get; set; }
        public DateTime dataDeNascimento { get; set; }
    }
}
