using Cadastro.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Domain.Entities
{
    public class UserEntity : Identity<int>
    {
        //private DateTime _dtb;
        //public UserEntity(DateTime dateBirthday)
        //{
        //    _dtb = dateBirthday;
        //}
        public string? Name { get; set; }
        public IEnumerable<EmailEntity>? Email { get; set; } //IEnumerateble cria uma lista
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
        public IEnumerable<FoneNumberEntity>? FoneNumber { get; set; }

        public DateTime DateBirthday { get; set; }

        //public DateTime dateBirthday { 

        //    get { return _dtb; } 
        //    set {
        //        if (value < DateTime.Now.AddYears(-18))
        //        {
        //            //Disparo erro
        //        }
        //        else
        //            _dtb = value;

        //    } 

        //}

        public IEnumerable<AddressEntity>? Address { get; set; }
    }
}
