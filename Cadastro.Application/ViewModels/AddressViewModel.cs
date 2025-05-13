using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.ViewModels
{
    public class AddressViewModel
    {
        public string? Street { get; set; }
        public int Number { get; set; }
        public string? Complement { get; set; }

        //public string estado { get; set; } // Select, obrigatório, com lista de estados brasileiros
        public string? ZipCode { get; set; }
    }
}
