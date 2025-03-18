﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Entities
{
    public class AddressEntity
    {
        public string street { get; set; }
        public int number { get; set; }
        public string complement { get; set; }

        //public string estado { get; set; } // Select, obrigatório, com lista de estados brasileiros
        public long ZipCode { get; set; } // ?
    }
}
