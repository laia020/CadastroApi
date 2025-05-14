using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cadastro.Application.ViewModels
{
    public  class UserViewModel
    {



        public string? Name { get; set; }
        public IEnumerable<EmailViewModel>? Email { get; set; } //IEnumerateble cria uma lista
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
        public IEnumerable<FoneNumberViewModel>? FoneNumber { get; set; }

        public DateTime DateBirthday { get; set; }


        public IEnumerable<AddressViewModel>? Address { get; set; }
    }
    
}
