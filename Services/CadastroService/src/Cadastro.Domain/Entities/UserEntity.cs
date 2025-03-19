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
        public IEnumerable<EmailEntity> email { get; set; } //IEnumerateble cria uma lista
        public string password { get; set; }
        public string comfirmPassWord { get; set; }
        public IEnumerable<FoneNumberEntity> foneNumber { get; set; }
        public DateTime dataDeNascimento { get; set; }

        public IEnumerable<AddressEntity> address { get; set; }
        
    }



   


}
