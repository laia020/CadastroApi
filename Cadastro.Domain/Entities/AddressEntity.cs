using Cadastro.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Entities
{
    public class AddressEntity: Identity<int>
    {
        public string? Street { get; set; }
        public int number { get; set; }
        public string? Complement { get; set; }

        //public string estado { get; set; } // Select, obrigatório, com lista de estados brasileiros
        public string? ZipCode { get; set; } 
        public int UserId { get; set; }
        public UserEntity? User { get; set; }
    }
}
