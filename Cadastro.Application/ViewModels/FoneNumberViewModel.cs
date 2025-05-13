using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.ViewModels
{
    public class FoneNumberViewModel
    {
        public int Id { get; set; }
        public string? Ddi { get; set; }
        public string? Ddd { get; set; }
        public string? Number { get; set; }
    }
}
